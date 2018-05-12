
import { Bank} from'./Bank.model';

export class Candidate {
  CandidateId : number;
  Name:string;
  Email:string;
  SkypeAddress:string;
  Cellphone:string;
  LinkedinAddress:string;
  City:string;
  State:string;
  Portfolio:string;
  FourHours:boolean;
  FourSixHours:boolean;
  SixEightHours:boolean;
  EightHours:boolean;
  HoursOnWeekends:boolean;
  Morning:boolean;
  Afternoon:boolean;
  Night:boolean;
  Dawn:boolean;
  Comercial:boolean;
  Salary:string;
  CrudLink:string;
  Bank: Bank;


}
