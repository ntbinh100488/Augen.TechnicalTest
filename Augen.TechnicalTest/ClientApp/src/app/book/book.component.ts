import { Component, OnInit, Inject, TemplateRef } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { BsModalService, BsModalRef } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-book',
  templateUrl: './book.component.html',
  styleUrls: ['./book.component.css']
})
export class BookComponent implements OnInit {
    public modalRef: BsModalRef;
    public message: string;
    public books: Book[];
    public filter: string;
    public baseUrl: string;
    public currentBook: any;
    public deliveryCosts: any;

    constructor(private http: HttpClient,
        private modalService: BsModalService,
        @Inject('BASE_URL') baseUrl: string) {
        this.baseUrl = baseUrl;
        http.get<Book[]>(baseUrl + 'api/bookstore').subscribe(result => {
            this.books = result;
        }, error => console.error(error));

        this.currentBook = {
            title: '',
            author: '',
            publishedDate: '',
            subtitle: ''
        };
        this.deliveryCosts = {
            motorbike: 0,
            train: 0,
            aircraft: 0,
        };
    }

    openModal(template: TemplateRef<any>, title: string, author: string, publishedDate: string, subtitle: string) {
        this.http.get<DeliveryCosts>(this.baseUrl + 'api/delivery', {
        }).subscribe(result => {
            this.deliveryCosts = result;
        }, error => console.error(error));

        this.currentBook = {
            title: title,
            author: author,
            publishedDate: publishedDate,
            subtitle: subtitle
        };

        this.modalRef = this.modalService.show(template, { class: 'modal-lg' });

    }

    confirm(): void {
        this.message = 'Confirmed!';
        this.modalRef.hide();
    }

    decline(): void {
        this.message = 'Declined!';
        this.modalRef.hide();
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
    subtitle: string;
}

interface DeliveryCosts {
    train: number;
    motorbike: number;
    aircraft: number;
}
