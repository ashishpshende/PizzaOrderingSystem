import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { User } from 'src/app/models/UAM/user';
import { catchError, map, tap } from 'rxjs/operators';
import { HttpClient,HttpHeaders } from '@angular/common/http';
import { NetworkService } from '../../common/network/network.service';
import { URLConstants } from 'src/app/constants/constants';
@Injectable({
  providedIn: 'root'
})
export class UserService {
  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  };
  public currentUser:User;
  constructor(private networkService:NetworkService,
     private http: HttpClient) { 

    this.currentUser = new User();
  }
  userProfile(): Observable<User> {
    return this.http.get<User>(URLConstants.USER_PROFILE)
    .pipe(
      tap(_ => this.networkService.log('fetched Entities')),
      catchError(this.networkService.handleError<User>('get', new User()))
    );
  }
  login(user:User):  Observable<Boolean> {
    return this.http.post<boolean>(URLConstants.USER_LOGIN, user, this.httpOptions).pipe(
      tap((newEntity: boolean) => this.networkService.log(`User Logged In`)),
      catchError(this.networkService.handleError<boolean>('Exception while user login'))
    );
  }
  logout(user:User):  Observable<Boolean> {
    return this.http.post<boolean>(URLConstants.USER_LOGOUT, user, this.httpOptions).pipe(
      tap((newEntity: boolean) => this.networkService.log(`User Logged In`)),
      catchError(this.networkService.handleError<boolean>('Exception while user login'))
    );
  }
}
