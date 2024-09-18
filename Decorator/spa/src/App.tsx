import React, { useState } from 'react';
import './App.css';
import { Beverage } from './Models/Beverages';
import { withCoffees } from './HOCs/withCoffees';
import { BeverageOption } from './HOCs/types';
import { withCoffeeCondiments } from './HOCs/withCondiments';
import { SimpleBeverageOptionComponent } from './components/SimpleBeverageOptionComponent';

export function App() {
  const [beverage, setBeverage] = useState<Beverage | undefined>(undefined);

  const resetBeverage = () => {
    setBeverage(undefined);
  };

  const showResult = () => {
    if(beverage === undefined) return;

    alert(`Your order: ${beverage.getDescription()}\nTotal Cost: $${beverage.cost().toFixed(2)}`);
  };

  const onOptionClicked = (beverageOption: BeverageOption) => {
    setBeverage(beverageOption.action(beverage));
  }

  const OptionsComponent = beverage === undefined ? withCoffees(SimpleBeverageOptionComponent) : withCoffeeCondiments(SimpleBeverageOptionComponent);
 
  return (
    <div>
      <h1>Coffee Shop</h1>
      <div>
        <h2>Selected Beverage: {beverage?.getDescription()}</h2>
      </div>
      {<OptionsComponent onClick={onOptionClicked} />}

      <button onClick={showResult}>Show result</button>
      <button onClick={resetBeverage}>Reset</button>
    </div>
  );
}

