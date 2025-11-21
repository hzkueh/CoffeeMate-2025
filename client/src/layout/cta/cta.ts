import { Component } from '@angular/core';

@Component({
  selector: 'app-cta',
  imports: [],
  templateUrl: './cta.html',
  styleUrl: './cta.css',
})
export class Cta {
  signup(){
    console.log('Get Started clicked');
  }
}
