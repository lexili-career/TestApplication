import { Component, OnInit } from '@angular/core';
//import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { AbstractControlOptions, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { first } from 'rxjs/operators';
import { UserService, AlertService } from './services';


@Component({
  selector: 'app-save-data',
  templateUrl: './save-data.component.html',
  styleUrls: ['./save-data.component.css']
})
export class SaveDataComponent implements OnInit {
  form!: FormGroup;
  loading = false;
  submitted = false;

  constructor(
      private formBuilder: FormBuilder,
      private route: ActivatedRoute,
      private router: Router,
     private userService: UserService,
     private alertService: AlertService
  ) {}

  ngOnInit() {
    
      this.form = this.formBuilder.group({
          firstName: ['', Validators.required],
          lastName: ['', Validators.required]
         
      });

      
  }

  // convenience getter for easy access to form fields
  get f() { return this.form.controls; }

  onSubmit() {
      this.submitted = true;
     
      // stop here if form is invalid
      if (this.form.invalid) {
          return;
      }
      else
      {
        this.loading = true;
        this.createUser();
        
      }

  }

  private createUser() {
    
      this.userService.create(this.form.value)
          .pipe(first())
          .subscribe((data) => {
            alert(data);
            window.location.reload();
          
          })
          .add(() => this.loading = false);
  }

  
}

