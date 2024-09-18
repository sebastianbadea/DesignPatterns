export interface Beverage {
    getDescription(): string;
    cost(): number;
  }
  
  export class Espresso implements Beverage {
    getDescription(): string {
      return "Espresso";
    }
  
    cost(): number {
      return 1.99;
    }
  }
  
  export class HouseBlend implements Beverage {
    getDescription(): string {
      return "House Blend Coffee";
    }
  
    cost(): number {
      return 0.89;
    }
  }
  