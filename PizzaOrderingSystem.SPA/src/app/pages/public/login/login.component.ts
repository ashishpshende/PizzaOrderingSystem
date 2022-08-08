import { Component, OnInit } from '@angular/core';
import { User } from 'src/app/models/UAM/user';
import { UserService } from 'src/app/services/entities/user/user.service';
import { Router } from '@angular/router';
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  user: User;
  constructor(private userService:UserService,private router: Router) {
    this.user =  new User();
   }

  ngOnInit(): void {
  }
  LoginButtonClicked()
  {this.router.navigate(['/pizza-menu']);
    this.userService.login(this.user).subscribe(result => {
     
    })
  }
}
