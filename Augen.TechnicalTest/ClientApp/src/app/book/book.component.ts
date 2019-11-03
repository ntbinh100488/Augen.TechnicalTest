import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';

@Component({
  selector: 'app-book',
  templateUrl: './book.component.html',
  styleUrls: ['./book.component.css']
})
export class BookComponent implements OnInit {
    public books: Book[];
    public filter: string;
    private baseUrl: string;

    constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
        this.baseUrl = baseUrl;
        http.get<Book[]>(baseUrl + 'api/bookstore').subscribe(result => {
            this.books = result;
        }, error => console.error(error));
    }

    ngOnInit() {
    }

    onSubmit() {
        console.log(this.filter);
        this.http.get<Book[]>(this.baseUrl + 'api/bookstore', {
            params: {
                queryString: this.filter
            },
        }).subscribe(result => {
            this.books = result;
        }, error => console.error(error));
    }
}

interface Book {
    title: string;
    authors: string;
    publishedDate: string;
}
