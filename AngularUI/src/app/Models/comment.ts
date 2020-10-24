import { Post } from "./post";
import { User } from "./user";

export class Comment {
  Id: number;
  CommentText: string;
  AddedDate: Date;

  User: User;
}
