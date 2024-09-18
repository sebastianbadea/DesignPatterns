import { Beverage } from "./Beverages";

export class Soy implements Beverage {
    private beverage: Beverage;
  
    constructor(beverage: Beverage) {
      this.beverage = beverage;
    }
  
    getDescription(): string {
      return `${this.beverage.getDescription()}, Soy`;
    }
  
    cost(): number {
      return this.beverage.cost() + 0.20;
    }
  }
  
  export class Milk implements Beverage {
    private beverage: Beverage;
  
    constructor(beverage: Beverage) {
      this.beverage = beverage;
    }
  
    getDescription(): string {
      return `${this.beverage.getDescription()}, Milk`;
    }
  
    cost(): number {
      return this.beverage.cost() + 0.10;
    }
  }
  