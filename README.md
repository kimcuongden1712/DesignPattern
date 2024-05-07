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


