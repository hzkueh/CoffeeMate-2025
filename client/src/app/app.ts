import { Component, inject, OnInit, signal } from '@angular/core';

import { Nav } from '../layout/nav/nav';

import { AccountService } from '../core/services/account-service';
import { Home } from "../features/home/home";
import { Footer } from "../layout/footer/footer";
import { HttpClient } from '@angular/common/http';
import { Account } from '../types/account';
import { lastValueFrom } from 'rxjs';

@Component({
  selector: 'app-root',
  imports: [Nav, Home, Footer],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App implements OnInit {

  protected title = 'CoffeeMate - Discover Your Perfect Coffee Match';
  private accountService = inject(AccountService);
  private http = inject(HttpClient);
  protected users = signal<Account[]>([]);

  async ngOnInit(){
    
    this.setCurrentUser();
  }

  setCurrentUser(){
    const accountString = localStorage.getItem('account');
    if(!accountString) return;

    const account = JSON.parse(accountString);
    this.accountService.currentUser.set(account);
  }
}
