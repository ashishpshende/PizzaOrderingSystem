
import { Injectable } from '@angular/core';
import { catchError, map, tap } from 'rxjs/operators';
import { HttpClient,HttpHeaders } from '@angular/common/http';
import { BaseModel } from 'src/app/models/base-model';
import { Observable, of } from 'rxjs';
import { MessageService } from '../message/message.service';
const AUTH_TOKEN_KEY = 'Authorization';
@Injectable({
  providedIn: 'root'
})
export class NetworkService {
  authorizationToken:any;
  
  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  };

  constructor(
    private http: HttpClient,
  
    private messageService: MessageService) {
    this.httpOptions = {
      headers: new HttpHeaders({ 'Content-Type': 'application/json','Authorization': '', "Source": "Angular-SPA"})
    };
  }

  
  getAll(url: string,data:any): Observable<BaseModel[]> {
    return this.http.get<BaseModel[]>(url)
      .pipe(
        tap(_ => this.log('fetched Entities')),
        catchError(this.handleError<BaseModel[]>('get', []))
      );
  }
  get(url: string,data:any): Observable<BaseModel> {
    return this.http.get<BaseModel>(url)
      .pipe(
        tap(_ => this.log('fetched Entities')),
        catchError(this.handleError<BaseModel>('get', new BaseModel()))
      );
  }
  post(url: string,data:any,entity: BaseModel): Observable<BaseModel> {
    return this.http.post<BaseModel>(url, entity, this.httpOptions).pipe(
      tap((newEntity: BaseModel) => this.log(`added Entity w/ id=${newEntity.id}`)),
      catchError(this.handleError<BaseModel>('add Entity'))
    );
  }
  delete(url: string,entity: BaseModel): Observable<BaseModel> {
    return this.http.delete<BaseModel>(url, this.httpOptions).pipe(
      tap(_ => this.log(`deleted`)),
      catchError(this.handleError<BaseModel>('delete Entity'))
    );
  }
  update(url: string,entity: BaseModel): Observable<any> {
    return this.http.put(url, entity, this.httpOptions).pipe(
      tap(_ => this.log(`update Entity`)),
      catchError(this.handleError<any>('update Entity'))
    );
  }
  // post(url:string,data:any,success:(any),failure:(string)) {
    

  //   var headers = new HttpHeaders();
      
  //   this.authorizationToken? headers.set(AUTH_TOKEN_KEY, this.authorizationToken):"";

  //   this.http.post(url, data, { headers })
  //     .subscribe(response => {
  //       //this.authorizationToken = response[AUTH_TOKEN_KEY];
  //       success(response);

  //     }, error => {
  //         failure(error);
  //     });
  // }

  // patch(url: string, data: any, success: (any), failure: (string)) {
  //   var headers = new HttpHeaders()
  //     .set(AUTH_TOKEN_KEY, this.authorizationToken);

  //   this.http.patch(url, data, { headers })
  //     .subscribe(data => {
  //       success(data);
  //     }, error => {
  //       failure(error);
  //     });
  // }

  // delete(url: string, success: (any), failure: (string)) {
  //   var headers = new HttpHeaders()
  //     .set(AUTH_TOKEN_KEY, this.authorizationToken);

  //   this.http.delete(url, { headers })
  //     .subscribe(data => {
  //       success(data);
  //     }, error => {
  //       failure(error);
  //     });
  // }

  // put(url: string, data: any, success: (any), failure: (string)) {
  //   var headers = new HttpHeaders()
  //     .set(AUTH_TOKEN_KEY, this.authorizationToken);

  //   this.http.put(url, data, { headers })
  //     .subscribe(data => {
  //       success(data);
  //     }, error => {
  //       failure(error);
  //     });
  // }
  public handleError<T>(operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {
  
      // TODO: send the error to remote logging infrastructure
      console.error(error); // log to console instead
  
      // TODO: better job of transforming error for user consumption
      this.log(`${operation} failed: ${error.message}`);
  
      // Let the app keep running by returning an empty result.
      return of(result as T);
    };
  }
  public log(message: string) {
    this.messageService.add(`HeroService: ${message}`);
  }
}
