import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PopularListComponent } from './popular-list.component';

describe('PopularListComponent', () => {
  let component: PopularListComponent;
  let fixture: ComponentFixture<PopularListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PopularListComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PopularListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
