import { Component, Input, signal } from '@angular/core';
import { Hero } from "../../layout/hero/hero";
import { FirstContent } from "../../layout/first-content/first-content";
import { HowItWorks } from "../../layout/how-it-works/how-it-works";
import { Cta } from "../../layout/cta/cta";
import { Register } from "../account/register/register";
import { Account } from '../../types/account';
import { Login } from "../account/login/login";

@Component({
  selector: 'app-home',
  imports: [FirstContent, HowItWorks, Cta, Register, Login],
  templateUrl: './home.html',
  styleUrl: './home.css',
})
export class Home {
  @Input({required:true}) accountFromApp: Account[] = [];
  protected registerMode = signal(false);
  protected loginMode = signal(false);

  showRegister(value : boolean){
    this.registerMode.set(value);
  }

  showLogin(value: boolean){
    this.loginMode.set(value);
  }
}
