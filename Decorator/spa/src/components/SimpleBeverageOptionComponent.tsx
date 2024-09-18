import { BeverageOption, WithBeverageProps } from "../HOCs/types";

type SimpleBeverageOptionComponentProps = { onClick: (option: BeverageOption) => void}
export const SimpleBeverageOptionComponent = (props: WithBeverageProps & SimpleBeverageOptionComponentProps) => {
  return  <>  
     {props.availableOptions.map((option) => (
      <button key={option.name} onClick={() => props.onClick(option)}>
        Select {option.name}
      </button>))}
      </>;
}