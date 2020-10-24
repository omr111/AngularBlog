import { Author } from './author';
import { Comment } from './comment';
import { Post } from './post';
import { User } from './user';

export class SinglePost extends Post {
    comments:Comment[];
    author:Author;
    
    
}
