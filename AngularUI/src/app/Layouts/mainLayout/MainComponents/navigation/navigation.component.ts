import { Component, OnInit } from "@angular/core";
import { Router, NavigationEnd } from "@angular/router";
enum activeClass {
  home = 1,
  about = 2,
  contact = 3
}
@Component({
  selector: "app-navigation",
  templateUrl: "./navigation.component.html",
  styleUrls: ["./navigation.component.css"]
})
export class NavigationComponent implements OnInit {
  isActive: activeClass;
  constructor(private router: Router) {
    router.events.subscribe(e=> {
      if (e instanceof NavigationEnd) {
        if (e.url.indexOf("anasayfa") > 0) {
          this.isActive = activeClass.home;
        } else if (e.url.indexOf("iletisim") > 0) {
          this.isActive = activeClass.contact;
        } else if (e.url.indexOf("hakkimizda") > 0) {
          this.isActive = activeClass.about;
        } else {
          this.isActive = activeClass.home;
        }
      }
    });
  }

  ngOnInit() {}
}
