import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Post } from 'src/app/Models/post';
import { PostService } from 'src/app/Services/post.service';

@Component({
  selector: 'app-search-post',
  templateUrl: './search-post.component.html',
  styleUrls: ['./search-post.component.css']
})
export class SearchPostComponent implements OnInit {

  constructor(private postService:PostService,private activedRoute:ActivatedRoute) { }
posts:Post[];
pageNumber:number=1;
perPageItemCount:number=2;
totalPostCount:number;
searchText:string;
ajax:any;

  ngOnInit() {
    //url'de query string olacağından this.activedRoute.paramMap üzerinden query string'i okuyamayız.
    //Bu yüzden url'in tümünü okuyoruz
    this.activedRoute.url.subscribe(params=> {
      this.posts = [];
      this.totalPostCount = 0;
      //url dinlendiği için artık params üzerinden get pageNumber diyemeyiz. 
      //Direkt activedRoute üzerinden snapshot params dememiz gerekir.
      if(this.activedRoute.snapshot.paramMap.get("pagaNumber"))
      this.pageNumber=Number(this.activedRoute.snapshot.paramMap.get("pageNumber"));
      if(this.activedRoute.snapshot.queryParamMap.get("s")){
        this.searchText=this.activedRoute.snapshot.queryParamMap.get("s");

        
      }
      this.postService.getSearchPost(this.searchText,this.perPageItemCount,this.pageNumber).subscribe(x=>{
        this.posts=x.posts;
        this.totalPostCount=x.totalPostCount;
      })

    })
  }

}
