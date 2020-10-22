import { Category } from "./category";

export class Post {
  Id: number;
  BackgroundImgUrl: string;
  releaseDate: Date;
  readCount: number;
  IsActive: boolean;
  CommentsCount: number;
  text: string;
  Description: string;
  title: string;
  likeCount: number;
  category: Category;
}
