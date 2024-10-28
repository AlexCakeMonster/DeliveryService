# Приложение для фильтрации заказов
Приложение фильтрует заказы для доставки в конкретный район города в ближайшие полчаса после времени
первого заказа.
## Как запустить через командную строку Windows
Скачать из репозитория папку StartFilterForDeliveryService и поместить её в корень диска "C".

Вызвать командную строку.

Указать в командной строке путь к папке с исполняемым файлом.
### Для запуска программы через командную строку следует передать следующие параметры:
1 аргумент - район города ```"A"``` ```"B"``` ```"C"``` ```"D"```

2 аргумент - путь к файлу с данными в формате ```"C:\StartFilterForDeliveryService\orders.json"```

3 аргумент - первое время доставки в формате ```yyyy-MM-dd HH:mm:ss```

4 аргумент - путь для записи .log файла в формате ```"C:\StartFilterForDeliveryService\OutputData\log.log"```

5 аргумент - путь для записи выходных данных в формате ```"C:\StartFilterForDeliveryService\OutputData\output.json"```

## Пример:
Подключаемся к папке с исполняемым файлом.
```
cd C:\StartFilterForDeliveryService
```
Запускаем приложение передавая в него параметры
```
FilterForDeliveryService.exe "D" "C:\StartFilterForDeliveryService\orders.json" "2024-10-22 12:00:00" "C:\StartFilterForDeliveryService\OutputData\log.log" "C:\StartFilterForDeliveryService\OutputData\output.json"
 ```
