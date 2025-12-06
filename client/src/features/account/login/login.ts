import { Component, EventEmitter, inject, output, Output } from '@angular/core';
import { AccountService } from '../../../core/services/account-service';
import { LoginCreds } from '../../../types/account';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-login',
  imports: [FormsModule],
  templateUrl: './login.html',
  styleUrl: './login.css',
})
export class Login {
  private accountService = inject(AccountService);
  cancelLogin = output<boolean>();
  protected creds = {} as LoginCreds;

  login() {
    this.accountService.login(this.creds).subscribe({
      next: result => {
        console.log(result);
        this.cancel()
      },
      error: error => alert(error.message)
    })
  }

  logOut(){
    this.accountService.logout();
  }

  cancel(){
    this.cancelLogin.emit(false);
  }
}
