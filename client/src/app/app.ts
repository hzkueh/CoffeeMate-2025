import { Component, signal } from '@angular/core';

import { Nav } from '../layout/nav/nav';
import { Hero } from "../layout/hero/hero";
import { Footer } from "../layout/footer/footer";
import { Cta } from "../layout/cta/cta";
import { HowItWorks } from "../layout/how-it-works/how-it-works";
import { FirstContent } from "../layout/first-content/first-content";

@Component({
  selector: 'app-root',
  imports: [Nav, Hero, Footer, Cta, HowItWorks, FirstContent],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected title = 'CoffeeMate - Discover Your Perfect Coffee Match';
}
