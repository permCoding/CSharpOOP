## LABRAB 3 - дедлайн 01.11.2020 24:00  
## дата занятия 31.10.2020  
### Практика работы с методами расширения LINQ  
**Техническое задание**  

Написать **консольное** приложение.  
По подобию проекта с Лекции про LINQ - **LINQTestQuery**  
Один метод Main и несколько методов (методы назвать Task_1, Task_2, и т.д.), которые решают указанные ниже задачи.

**Реализовать нижеперечисленные задачи:**  

1 вывести список абитуриентов мужского пола в алфавитном порядке по возрастанию по имени  

2 вывести список абитуриентов любого пола, которые набрали суммарный балл по трём экзаменам ЕГЭ не менее, чем минимальный проходной балл из всех направлений, отсортировав абитуриентов по убыванию их суммарного балла по ЕГЭ  

3 на вход подаётся наименование направления обучения, например, ПИб, вывести на экран для указанного направления обучения ТРЁХ лучших по баллу ЕГЭ абитуриентов (и документы подавали на данное направление), отсортировав их по набранному баллу по убыванию  

4 на вход подаётся наименование направления обучения, например, ПИнб, в ответ вывести ВСЕХ абитуриентов, которые смогли набрать балл для данного направления (и документы подавали на данное направление), отсортировав их по набранному баллу по убыванию, а по имени по возрастанию  

5 на вход подаётся наименование направления обучения, например, ПИнб, в ответ вывести ВСЕХ абитуриентов, которые смогли поступить на выбранное ими направление (условие поступления: попасть по баллам ЕГЭ в список лучших в рамках отведённого лимита на направление, даже, если и меньше проходного балла), отсортировав их по набранному баллу по убыванию, а по имени по возрастанию  

6 на вход подаётся наименование направления обучения, например, ИСб, вывести лучшего по баллам ЕГЭ из непопавших в набор  

7 вывести на экран список направлений и количество абитуриентов, подавших документы на это направление  

8 вывести на экран названия направлений обучения, отсортировав их в порядке убывания по среднему баллу набранных абитуриентов  (те, которые уложились в лимит набора)  


---  

Задания выполнять с использованием методов LINQ. Запросы, при написании кода, структурировать вертикально по методам, например, так:  
```
var grouping = persons
    .GroupBy(item => item.Age)
    .OrderBy(item => item.Key);
```
Чем больше реализовано методами **LINQ**, тем выше оценка.  
Разрешается использовать **foreach** для вывода результатов.  

---  

Для данной лабораторки вам предоставлены два текстовых файла с данными:  
- directions  
- students  

В каждом файле первая строка - титульная, там описаны названия соответствующих полей таблицы. Данные начинаются со второй строки - именно их и нужно считывать. Данные идут построчно, в качестве разделителя используется символ ';'.  

---  

А вот и сами файлы - их содержимое скопируйте отсюда и вставьте в качестве ресурсов вашего проекта в VS.  
```
В файле про направления обучения такие поля:  
- идентификатор направления,  
- наименование направления,  
- минимальный проходной балл,  
- количество мест этого набора.  
```
```
имя файла: directions.txt, содержимое файла:  
idDirect;NameDirect;minBall;limit
1;ПИнб;210;15
2;ПИб;185;10
3;ИСб;200;12
```

---  

```
В файле про абитуриентов такие поля:  
- идентификатор абитуриента,  
- Фамилия абитуриента,  
- пол,  
- балл по математике,  
- балл по русскому,  
- балл по информатике,  
- идентификатор выбранного направления обучения.  
```
```
имя файла: students.txt, содержимое файла:  
idStudent;NameStudent;sex;ballMath;ballLang;ballInf;idDirect  
1;Иванов;м;60;70;80;1
2;Петров;м;60;62;60;2
3;Яценко;ж;70;77;70;3
4;Бойко;ж;60;64;62;2
5;Миков;м;60;70;88;1
6;Мищенко;ж;60;52;60;3
7;Ямбург;ж;70;77;75;3
8;Абросов;м;56;62;62;2
9;Кикова;ж;66;75;80;1
10;Кикабидзе;ж;54;62;60;1
11;Луканин;м;70;75;90;3
12;Жданов;м;68;66;62;2
13;Маков;м;60;70;50;1
14;Сынбаева;ж;60;52;50;2
15;Занозкина;ж;70;57;70;3
16;Машина;ж;60;54;62;2
17;Градский;м;62;57;70;1
18;Петровский;м;60;62;66;2
19;Берг;ж;74;77;74;3
20;Крамола;ж;66;66;62;2
21;Иванова;ж;60;70;86;1
22;Петрова;ж;70;62;90;2
23;Ященко;м;80;78;73;3
24;Бойков;м;65;64;68;2
25;Микова;ж;60;55;88;1
26;Мищенко;м;60;58;64;3
27;Ямбург;м;80;77;75;3
28;Абросова;ж;76;62;62;2
29;Киков;м;66;75;84;1
30;Кикабидзе;м;84;62;60;1
31;Луканина;ж;72;75;92;3
32;Жданова;ж;61;86;67;2
33;Макова;ж;64;77;70;1
34;Сынбаев;м;67;62;62;2
35;Занозкин;м;70;57;70;3
36;Мишкин;м;60;74;62;2
37;Градская;ж;60;60;80;1
38;Петровская;ж;60;62;78;2
39;Берг;м;80;73;70;3
40;Крамолов;м;60;64;62;2
51;Панина;ж;60;70;78;1
52;Пушкина;ж;66;62;61;2
53;Лермонов;м;70;72;75;3
54;Сахаров;м;67;64;63;2
55;Ахматова;ж;60;70;68;1
56;Есенин;м;65;58;61;3
57;Маяковский;м;68;74;75;3
58;Пахмутова;ж;56;67;63;2
59;Булгаков;м;65;70;72;1
60;Достоевский;м;57;62;60;3
```




---  
