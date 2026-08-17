# 🍕 Restaurant Simulation

C# OOP ilə hazırlanmış restoran məhsullarının idarə olunması
simulyasiyası.

## 📌 Features

-   `Food` --- abstract base class
-   `Pizza` və `Fries` --- `Food` class-dan inheritance
-   `CalcPrice()` --- məhsula uyğun qiymət hesablanması
-   `ToString()` override
-   `IFoodService` / `FoodService`
-   `IPizzaService` / `PizzaService`
-   Property validation
-   OOP prinsiplərinin tətbiqi

## ⚙️ Services

### FoodService

-   `WhenWillPrepared()` --- yeməyin hazırlanacağı vaxtı hesablayır.
-   `GetCountByCalories()` --- verilmiş kalori limitindən yüksək
    kalorili qidaların sayını qaytarır.

### 🍕 PizzaService

-   `CreatePizza()` --- yeni `Pizza` obyekti yaradır.
-   `GetBiggestRadiusPizza()` --- ən böyük radiusa sahib pizzanı tapır.

## 🧠 OOP Principles

Layihədə əsas C# OOP prinsiplərindən istifadə olunub:

-   **Abstraction** --- `Food` abstract class vasitəsilə ümumi
    davranışların müəyyənləşdirilməsi
-   **Inheritance** --- `Pizza` və `Fries` class-larının `Food`-dan
    törəməsi
-   **Encapsulation** --- property və validation vasitəsilə məlumatların
    qorunması
-   **Polymorphism** --- `CalcPrice()` və `ToString()` metodlarının
    override edilməsi
-   **Interfaces** --- `IFoodService` və `IPizzaService` vasitəsilə
    service davranışlarının müəyyənləşdirilməsi

## 🛠️ Technologies

-   C#
-   .NET
-   Object-Oriented Programming (OOP)
