import { HttpClient } from '@angular/common/http';
import { inject, Injectable, signal } from '@angular/core';
import { Account, LoginCreds, RegisterCreds } from '../../types/account';
import { tap } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class AccountService {
  private http = inject(HttpClient);
  currentUser = signal<Account | null>(null);

  baseUrl = 'https://localhost:7213/api';

  register(creds : RegisterCreds){
    return this.http.post<Account>(this.baseUrl + '/account/register', creds).pipe(
      tap(account =>{
        if(account){
          this.setCurrentUser(account)
        }
      })
    );
  }

  login(creds : LoginCreds){
    return this.http.post<Account>(this.baseUrl + '/account/login', creds).pipe(
      tap(account =>{
        if(account){
          this.setCurrentUser(account)
        }
      })
    );
  }

  setCurrentUser(account : Account){
    localStorage.setItem('account', JSON.stringify(account))
    this.currentUser.set(account)
  }

  logout(){
    localStorage.removeItem('account');
    this.currentUser.set(null);
  }
}
