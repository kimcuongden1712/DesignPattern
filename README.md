# DesignPattern

# Singleton
Intent: 
- Singleton là 1 creattional design pattern, để đảm bảo rằng mỗi class chỉ được instaince 1 lần và đồng thời cung cấp 1 global entry-point để giúp các class khác có thể truy cập.
- Là trung tâm ứng dụng

Motivation:
Mục đích để giải quyết 2 vấn đề:
- Việc quản lý, truy cập chỉ 1 lần instance
- Tránh việc ghi đè như khi sử dụng biến golbal

Pros/Cons(ưu nhược điểm)
Pros
- Phải chắc chắn có duy nhất 1 instance
- Cung cấp 1 global entry point
- Đc khởi tạo sau lần request đầu tiên

Cons
- Vi phạm Single Reponsibility Principle (S trong SOLID)
- Xảy ra nhiều case liên quan đến multithreaded ENV
- Khó Unit test

Struct
- Có 1 static method GetInstance trả về chính Instance của chính class
- Constructor của class cũng bị che đi bằng cách định nghĩa private, việc này đảm bảo rằng mỗi lần khởi tạo instance thì phải đi qua GetInstance

```
If(instance == null)
{
    instance = new Singleton
}
return instance
```

# Prototype
Intent: 
- Prototype cho phép tạo ra 1 đối tượng mới, bằng cách sao chép tất cả các thuộc tính từ 1 đối tượng có sẵn mà ko dẫn đến việc các đối tượng này phụ thuộc vào nhau.
- Tối ưu bộ nhớ, khởi tạo 1 object mới.
- Cung cấp tính linh hoạt cho việc cấu hình

Motivation:
Mục đích để giải quyết 2 vấn đề:
- Copy nhanh 1 object
- Clone nhanh chóng
- Không phụ thuộc vào object cần clone
- Có 1 method duy nhất Clone

Pros/Cons(ưu nhược điểm)
Pros
- Kiến trúc linh hoạt
- Loại bỏ từ khoá New

Cons
- Class có reference phức tạp sẽ khó khăn

Struct
- Client: Nơi instance prototype để tạo nên các object bằng việc clone 1 object, Client tương tác với prototype Interface, Các prototype class sẽ implement prototype Interface

```
Class Employee : ICloneable
```

# Factory Method Design Pattern
Intent: 
- Là 1 creational design pattern, cung cấp 1 Interface hoặc 1 Abtrac class để create Object
- Ưu điểm là cho phép các class implement quyết định Object nào đc khởi tạo
- Tăng cường linh hoạt và mở rộng trong ứng dụng

Motivation:
Mục đích để giải quyết 2 vấn đề:
- 

Pros/Cons(ưu nhược điểm)
Pros
- 

Cons
- 

Struct
- 

```
Class Employee : ICloneable
```

