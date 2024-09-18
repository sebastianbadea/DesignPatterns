import { Beverage } from "../Models/Beverages";

export interface BeverageOption {
    name: string;
    action: (beverage: Beverage | undefined) => Beverage;
  }

  export interface WithBeverageProps {
    availableOptions: BeverageOption[]
  }
  