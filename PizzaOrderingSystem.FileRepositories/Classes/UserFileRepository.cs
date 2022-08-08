using Newtonsoft.Json;
using PizzaOrderingSystem.Models.Classes.Users;
using ProjectAssignment.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Security.Cryptography;
using System.Text.Json.Serialization;
using BC = BCrypt.Net.BCrypt;

namespace PizzaOrderingSystem.FileRepositories.Classes
{
    public class UserFileRepository : IUserRepository
    {
        private string BaseFolderPath;
        private string FilePath;

        private static readonly JsonSerializerOptions _options = new JsonSerializerOptions() { DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull };
        public UserFileRepository()
        {
            var path = Directory.GetCurrentDirectory();
            path = path.Substring(0, path.LastIndexOf('\\'));
            BaseFolderPath = Path.Combine(path, "PizzaOrderingSystem.FileRepositories\\AppData");
            FilePath = BaseFolderPath + "\\users.json";
        }
        public User Get(int userId)
        {
            try
            {
                var reult = new User();
                var jsonData = System.IO.File.ReadAllText(FilePath);
                var users = JsonConvert.DeserializeObject<List<User>>(jsonData);
                reult = users.FirstOrDefault(x => x.Id == userId);
                return reult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Login(User user)
        {
            try
            {
                var result = new User();
                var jsonData = System.IO.File.ReadAllText(FilePath);
                var users = JsonConvert.DeserializeObject<List<User>>(jsonData);
                result = users.FirstOrDefault(x => x.UserName == user.UserName);


                return true;//!BC.Verify(user.Password, result.Password);

              
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Save(User user)
        {
            try
            {
                var jsonData = System.IO.File.ReadAllText(FilePath);
                var users = JsonConvert.DeserializeObject<List<User>>(jsonData);
                foreach (var accuser in users)
                {
                    if (user.Id == user.Id)
                    {                             
                        return false;
                    }
                }
                user.Password = BC.HashPassword(user.Password);
                users.Add(user);
                var jsonString = System.Text.Json.JsonSerializer.Serialize(users, _options);
                File.WriteAllText(FilePath, jsonString);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Update(User user)
        {
            try
            {
                var jsonData = System.IO.File.ReadAllText(FilePath);
                var users = JsonConvert.DeserializeObject<List<User>>(jsonData);
                var index = 0;
                foreach (var accuser in users)
                {
                    if (user.Id == user.Id)
                    {
                        break;
                    }
                    index++;
                }
                users.RemoveAt(index+1);
                users.Add(user);
                var jsonString = System.Text.Json.JsonSerializer.Serialize(users, _options);
                File.WriteAllText(FilePath, jsonString);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
