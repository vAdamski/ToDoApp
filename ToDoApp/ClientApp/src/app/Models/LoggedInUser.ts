import { MainTask } from "./MainTask";

export class LoggedInUser {
  public firstName: string;
  public lastName: string;
  public userId: string;
  public mainTasks: Array<MainTask>;
}
