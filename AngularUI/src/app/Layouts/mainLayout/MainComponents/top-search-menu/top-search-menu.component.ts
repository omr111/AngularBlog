import { Component, OnInit } from "@angular/core";
import { Router } from "@angular/router";

@Component({
  selector: "app-top-search-menu",
  templateUrl: "./top-search-menu.component.html",
  styleUrls: ["./top-search-menu.component.css"],
})
export class TopSearchMenuComponent implements OnInit {
  constructor(private route: Router) {}

  ngOnInit() {}
  searchPost(searchText) {
    if (searchText =="" || searchText == null || searchText == undefined) {
      return false;
      
    }else{
      this.route.navigateByUrl(`/arama/sayfa/1?s=${searchText}`);
    }
  }
}
