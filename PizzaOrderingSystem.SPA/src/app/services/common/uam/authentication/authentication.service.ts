import { Injectable } from '@angular/core';
import { User } from 'src/app/models/UAM/user';

@Injectable({
  providedIn: 'root'
})
export class AuthenticationService {
public currentUser: User;
  constructor() { 
    this.currentUser = new User();
  }
}
