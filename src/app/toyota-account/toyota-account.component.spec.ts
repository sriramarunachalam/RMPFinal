import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ToyotaAccountComponent } from './toyota-account.component';

describe('ToyotaAccountComponent', () => {
  let component: ToyotaAccountComponent;
  let fixture: ComponentFixture<ToyotaAccountComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ToyotaAccountComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ToyotaAccountComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
