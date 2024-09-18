import { ComponentType } from "react";
import { Beverage, Espresso, HouseBlend } from "../Models/Beverages";
import { BeverageOption, WithBeverageProps } from "./types";
import { Subtract } from "utility-types";


export const withCoffees = <P extends WithBeverageProps>(WrappedComponent: ComponentType<P>) => {
  return (props: Subtract<P, WithBeverageProps>) => {
    const addEspresso = () => {
      return new Espresso();
    };

    const addHouseBlend = () => {
      return new HouseBlend();
    };

    return (
      <WrappedComponent
        {...(props as P)}
        availableOptions={[{name: "Expresso", action: addEspresso },{ name: "HouseBlend", action:addHouseBlend}]}
      />
    );
  };
};