import { Component, OnInit } from "@angular/core";
import { Category } from "src/app/Models/category";
import { CategoryService } from "../../../../Services/category.service";
@Component({
  selector: "app-categories",
  templateUrl: "./categories.component.html",
  styleUrls: ["./categories.component.css"],
})
export class CategoriesComponent implements OnInit {
  constructor(private categoryService: CategoryService) {}
  categories: Category[];
  ngOnInit() {
    this.categoryService.getAllCategories().subscribe(data => {
      this.categories = data;
    });
  }
}
