## Программная инженерия ООП - 2020-2021
 
--- 
#### Объём учебной дисциплины:
* семестр 1: Лекций - 9; л/р - 9; Зачёт  
* семестр 2: Лекций - 9; л/р - 9; Экзамен  

## [Рейтинг группы](https://docs.google.com/spreadsheets/d/1jlt7L5XOcl_6pemtFV1jxBUGUOMnAYvBJZn3uSk4uJQ/edit?usp=sharing)  

## Задания к лабораторным занятиям  
[LABRAB 1](https://github.com/permCoding/CSharpOOP/blob/master/LABRAB1.md)  
[LABRAB 2 Часть 1,2,3](https://github.com/permCoding/CSharpOOP/blob/master/LABRAB2.md)  
[LABRAB 3](https://github.com/permCoding/CSharpOOP/blob/master/LABRAB3.md)  

```

```


### **Точки входа для дистанционных занятий:**  
* [Первая точка входа BBB](https://bbb.psaa.ru/b/and-jcn-9at)  
* [Вторая точка входа BBB5](https://bbb5.psaa.ru/b/and-rqi-vdx)  
* [Третья точка входа Zoom](https://us04web.zoom.us/j/6931731236?pwd=T1lNamFoMjJtMHlSbWVKZHF2d3Qwdz09)  
* [Четвёртая точка входа MyWebinar](https://go.mywebinar.com/npkg-qmfz-cgsl-cdtw)  
* [Пятая точка входа Discord](https://discord.gg/8MnQJ3t)  

### **Учебники тут:**  
* [Теория](https://pcoding.ru/pdf/CSharpOOP.pdf)  
* [Практикум](https://pcoding.ru/pdf/CSharpJunior.pdf)  
* [Работа с БД](https://pcoding.ru/pdf/CSharpMySQL.pdf)  
* [Примеры кода](https://pcoding.ru/pdf/CSharpHelp.pdf)  

### **Полезные ссылки:**  
* [Документация по .Net](https://docs.microsoft.com/ru-ru/dotnet/)  
* [Фрагменты кода C# по умолчанию](https://docs.microsoft.com/ru-ru/visualstudio/ide/visual-csharp-code-snippets?view=vs-2019)  

*Установить*  
1) **IDE** Visual Studio 2019: [ссылка](https://visualstudio.microsoft.com/ru/vs/)  
2) **Редактор тем** в VS2019: [ссылка](https://marketplace.visualstudio.com/items?itemName=VisualStudioPlatformTeam.VisualStudio2019ColorThemeEditor)  
3) **Цветовые схемы** для редактора кода: [ссылка](https://studiostyl.es/)  
4) **Расширение GitHub** Extension for Visual Studio (через меню VS "Расширения"/"Управление расширениями") или [скачать](https://marketplace.visualstudio.com/items?itemName=GitHub.GitHubExtensionforVisualStudio).  
5) **Клиент Git`а** для Windows - [ссылка](https://central.github.com/deployments/desktop/desktop/latest/win32)  
6) **Клиент Git`а** для андроида - [ссылка](https://play.google.com/store/apps/details?id=com.thirtydegreesray.openhub&hl=en)  
7) **Git** для Windows - [ссылка](https://git-scm.com/)  

*Для развития:*  
1) Он-лайн аудио-подкаст Мысли и методы: [ссылка](https://soundcloud.com/mimpod)  
2) Приложение для андроида для этих подкастов: [ссылка](https://play.google.com/store/apps/details?id=com.soundcloud.android&hl=ru)  

---

Чтобы сменить ***горячие клавиши*** в редакторе кода VS2019 на привычные вам, следуйте пунктам меню (я выбрал там схему для Visual Studio Code):  
```
Параметры/Окружение/Клавиатура/Применить схему назначения клавиш  
```

---

**Лекция 1, 2**  
Редактор Visual Studio и GitHub  
Глубина стека функций  
Одно решение + несколько проектов  
Виды сборок: exe и dll  
namespace  

**Лекция 3, 4**  
Событийное программирование  
События мыши  
partial class  
Designer.cs  
Переменная sender  

**Лекция 5, 6**  
prog обработка нажатия на radioButton  
prog Убегающая кнопка  
prog Двигаем объект по форме  

коллекция Controls  
Второй аргумент EventArgs e  
Элементы UI от win forms  
Приоритет событий  

---  

**Лекция 7, 8**  

[Поиграть в лягушек](https://pcoding.ru/frog/frog.html)  
[Скачать flash и играть локально](https://github.com/permCoding/Magistr-2020/blob/master/images/frogs.swf)  

динамически создаваемые объекты  
List объектов  
Многооконный интерфейс  
События клавиатуры  
Парсер сайтов  

---  

**Лекция 9, 10**  
**13.10.2020**  

1} подключаем готовую библиотеку frogsDLL.dll - **FrogsTestDLL**  

2} механизм и события Drag-and-drop - **DragAndDrop_Images**, **DragAndDrop_ImagesSwap**  

3} коллекции Queue, Stack, Dictionary, HashSet  
> [Коллекции - справка](https://metanit.com/sharp/tutorial/4.9.php)  
> [Моё видео про коллекции в C#](https://youtu.be/Og3AFF9FKWk)  
>> Создаем свою DLL. Работаем с Collections.
Перегрузка методов. Отличие массива от коллекций.
Коллекции Список - List, Стек - Stack, Очередь - Queue.
Генератор строк.  

4} параметры по ссылке и по значению  

5} способы решения [задачи о Зайчике](https://acmp.ru/index.asp?main=task&id_task=11) -  **rabbit_routes**  
>- рекурсия  
>- рекурсия с меморизацией  
>- очередь  
>- словарь  
>- динамика (без разбора)  

6} рекурсивное решение задачи аналог frogs - **ReSortWord**  
> Есть строка из символов "ABCD" (можно другое кол-во).  
> Размешаем введённую строку.  
> Нужно **найти путь минимальной длины в исходную позицию**.  
> Один шаг пути это swap двух символов.  
> Одно условие - всегда меняем символ из нулевой позиции и какой-то другой.  
> Например, было так: DCBA, а возможный ход такой: ACBD - поменяли позицию 0 и 3.  
> Полный пример поиска минимального пути в позицию ABC из позиции ACB:  
>> ACB  
>> CAB  
>> BAC  
>> ABC  


---  

**Лекция 11, 12** - **LINQ**  
**20.10.2020**  
[Документация по LINQ](https://docs.microsoft.com/ru-ru/dotnet/csharp/linq/)  
[Список методов](https://github.com/permCoding/CSharpOOP/blob/master/LINQ.md)  

1} дорешиваем "Зайчика" очередью - смотрим как работает эта структура данных в C# -  **rabbit_routes**  
2} сравниваем передачу данных по ссылке и как значение - сравниваем Class и Struct - **ClassAndStruct**  
3} примеры использования методов расширения **LINQ** - **LINQTest**  
4} прототип проекта к лаб`е - **xxxxxxxxxx**  

---  

**Лекция 13, 14** - **LINQ**  
**27.10.2020**  
[Документация по LINQ](https://docs.microsoft.com/ru-ru/dotnet/csharp/linq/)  
[Разбор технологии LINQ](https://professorweb.ru/my/LINQ/base/level1/info_linq.php)  
[Список методов](https://github.com/permCoding/CSharpOOP/blob/master/LINQ.md)  

Вопросы с предыдущей Лекции:  
[ConvertTo vs Int32.Parse](https://repl.it/@pCoding/ConvertTo)  

Проект с текущей Лекции **LINQTestQuery**  

По данной теме будут: 1) **задания на Степике** и 2) **небольшой проект**...  

### Language-Integrated Query  
* синтаксис **ЗАПРОСОВ**  
* синтаксис **МЕТОДОВ**  

**ВАЖНО:**  
_ Выражение запроса можно использовать для получения и преобразования данных из любого источника данных, поддерживающего LINQ. Например, можно одним запросом получить данные из базы данных SQL и создать на их основе выходной XML-поток.  
_ Все переменные в выражениях запросов строго типизированы, хотя их тип не нужно указывать явным образом, поскольку компилятор определит его автоматически.  
_ Запрос исполняется не там где декларируется и присваивается в переменную запроса, а только в момент непосредственного обращения к переменной запроса, например, с помощью инструкции foreach или метода MoveNext(), так как он хранится в формате итератора.  
_ Во время компиляции выражения LINQ записанные в синтаксисе запроса преобразуются в вызовы синтаксиса методов. Любой запрос, который может быть выражен с помощью синтаксиса запросов, также может быть выражен с помощью синтаксиса методов. Между этими формами синтаксиса нет никакой разницы в семантике или производительности.  
_ Некоторые операции LINQ, например Count или Max, не имеют эквивалентных предложений в синтаксисе запросов и должны выражаться как вызовы методов.  

---  

**Лекция 15, 16** - **CSV**  
**03.11.2020**  

[Репозиторий CsvHelper](https://joshclose.github.io/CsvHelper/)  

---  

**Лекция 17, 18** - **SQLite**  
**10.11.2020**  

---  

Список справочных видео-уроков от меня:  
=======================================

https://youtu.be/Lh6b6NsWFys	- static в C#  
https://youtu.be/Og3AFF9FKWk	- Динамические библиотеки. Коллекции.  
https://youtu.be/wQKHyaN_76g	- Я черепаший БОГ - как подключить DLL  
https://youtu.be/1TwWfJeNjHE	- Динамические компоненты в C#  
https://youtu.be/2EZ_E8sWQIo	- Как узнать нажатую radioButton  
https://youtu.be/vz3sj8O820E	- Перечисления в C# - enum  
https://youtu.be/6pGj00h6OdM	- Как скрафтить ИНТЕРФЕЙС в C#  
https://youtu.be/VDSOvAuhwlo	- Освободите Вилли - оператор using в C#  
https://youtu.be/29q1Lz8ErMc	- Два способа передать значения между формами в C#  
https://youtu.be/z-Lp2Be24JA	- Перегрузка операций в C#  
https://youtu.be/a4yQYJjf7Pc	- Обобщённые методы в C#  
https://youtu.be/mF9cdmv5Q68	- Передача параметров по ссылке в C#  

https://youtu.be/K1EqyVOkv70	- SQLite + CSV + запросы многие-ко-многим  

---  



|| || || || || || || || || || || || || || || || || || || || || || || || || || || || || || || || || || || || 