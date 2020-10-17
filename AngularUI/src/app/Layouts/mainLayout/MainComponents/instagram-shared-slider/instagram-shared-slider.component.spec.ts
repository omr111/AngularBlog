import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { InstagramSharedSliderComponent } from './instagram-shared-slider.component';

describe('InstagramSharedSliderComponent', () => {
  let component: InstagramSharedSliderComponent;
  let fixture: ComponentFixture<InstagramSharedSliderComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ InstagramSharedSliderComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(InstagramSharedSliderComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
