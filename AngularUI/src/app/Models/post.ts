import { Category } from "./category";

export class Post {
  Id: number;
  BackgroundImgUrl: string;
  ReleaseDate: Date;
  ReadCount: number;
  IsActive: boolean;
  CommentsCount: number;
  Text: string;
  Description: string;
  Title: string;
  LikeCount: number;
  Category: Category;
}
