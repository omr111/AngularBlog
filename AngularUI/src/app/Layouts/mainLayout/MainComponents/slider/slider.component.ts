import { Component, OnInit } from '@angular/core';

declare var $: any;

@Component({
  selector: 'app-slider',
  templateUrl: './slider.component.html',
  styleUrls: ['./slider.component.css']
})
export class SliderComponent implements OnInit {

  constructor() { }

  ngOnInit() {

    /* slider nerede? çalıştı mı? */

    setTimeout(() => {
      $('#slider').layerSlider({
        sliderVersion: '6.0.0',
        responsiveUnder: 0,
        maxRatio: 1,
        slideBGSize: 'auto',
        hideUnder: 0,
        hideOver: 100000,
        skin: 'outline',
        thumbnailNavigation: 'disabled',
      });
    }, 0);

  }

}
