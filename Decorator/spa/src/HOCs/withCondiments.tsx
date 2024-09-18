import React, { ComponentType, useState } from "react";
import { Beverage } from "../Models/Beverages";
import { Milk, Soy } from "../Models/Condiments";
import { BeverageOption, WithBeverageProps } from "./types";
import { Subtract } from "utility-types";

export const withCoffeeCondiments = <P extends WithBeverageProps>(WrappedComponent: ComponentType<P>) => {
  return (props: Subtract<P, WithBeverageProps>) => {
    const addMilk = (beverage: Beverage) => {
      return new Milk(beverage);
    };

    const addSoy = (beverage: Beverage) => {
      return new Soy(beverage);
    };

    return (
      <WrappedComponent
        {...(props as P)}
        availableOptions={[{name: "Milk",action: addMilk },{ name:"Soy", action:addSoy}]}
      />
    );
  };
};