
# Book Deatils Backend API
This application is used to store and fetch the book details from the database along with MLA Citation and Chicago Citation.
## API Reference

#### Get all books

```http
  GET /api/book/sorted-by-publisher-author-title
```

| Description                |
|  |  | :------------------------- |
 | get all books from table sorted by publisher, author and title. |

#### Get all books

```http
  GET /api/book/sorted-by-author-title
```

| Description                |
|  |  | :------------------------- |
 | get all books from table sorted by author and title. |

#### Get books total price

```http
  GET /api/book/total-price
```

| Description                |
|  |  | :------------------------- |
 | get total price of all books from table. |

 #### Post bulk insert 

```http
  GET /api/book/bulk-insert-books
```

| Description                |
|  |  | :------------------------- |
 | bulk insert list of data into the table at once. |

 

