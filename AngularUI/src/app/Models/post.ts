import { Category } from "./category";

export class Post {
  id: number;
  backgroundImgUrl: string;
  releaseDate: Date;
  readCount: number;
  IsActive: boolean;
  commentCount: number;
  text: string;
  Description: string;
  title: string;
  likeCount: number;
  category: Category;
}
