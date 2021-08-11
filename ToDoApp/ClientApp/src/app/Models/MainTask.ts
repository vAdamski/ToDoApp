import { UnderTask } from "./UnderTask";

export class MainTask {
  Id: number;
  Title: string;
  Description: string;
  IsDone: boolean;
  Deadline: Date;
  UnderTasks: Array<UnderTask>
}
