import { AfterViewInit, Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'demo-app';
  myimage: string="assets/img/space.jpg";
  myphoneimage: string="assets/img/space.mobile.jpg";

}
