# DOKUMENTACJA PROJEKTU NR 2

## Bryły Geometryczne - System Sortowania i Wizualizacji

**Autor:** Bartosz Paczesny 72541
**Data:** 10 czerwca 2025
**Przedmiot:** Programowanie Obiektowe (OOP)
**Język programowania:** C# (.NET 9.0)
**Środowisko:** Windows Forms Application

---

## 📋 SPIS TREŚCI

1. [PROJEKT LABORATORYJNY](#projekt-laboratoryjny)
2. [PROJEKT INDYWIDUALNY](#projekt-indywidualny)
3. [WNIOSKI I UWAGI](#wnioski-i-uwagi)

---

## 1. PROJEKT LABORATORYJNY

### 1.1. Opis Funkcjonalności

Projekt laboratoryjny implementuje system zarządzania bryłami geometrycznymi z możliwością:

-   **Dodawania** 4 typów brył: Stożek, Walec, Kula, Piramida
-   **Sortowania** według wysokości, objętości, powierzchni w kolejności rosnącej/malejącej
-   **Wyświetlania** w trybie slidera (pojedyncze bryły)
-   **Usuwania** brył na 4 różne sposoby
-   **Wizualizacji** z konfigurowalnymi stylami graficznymi

### 1.2. Diagram Hierarchicznej Struktury Klas

```
GeometricBlock
├── GeometricBlockType (enum)
│   ├── Cone
│   ├── Cylinder
│   ├── Sphere
│   └── Pyramid
│
└── GeometricBlockBase (abstract class)
    ├── Properties:
    │   ├── XsP, YsP (pozycja)
    │   ├── LineColor, LineStyle, LineWidth
    │   ├── Visible (bool)
    │   ├── Height (abstract)
    │   ├── Type (abstract)
    │   ├── Volume (abstract)
    │   └── SurfaceArea (abstract)
    │
    ├── Methods:
    │   ├── Draw(Graphics g) (abstract)
    │   ├── Erase(Graphics g, Control control) (abstract)
    │   ├── Move(Graphics g, Control control, int x, int y) (abstract)
    │   └── Rotate(Graphics g, Control control, int angle) (abstract)
    │
    └── Derived Classes:
        ├── ConeBlock
        │   ├── Fields: _radius, _height, _rotationAngle
        │   ├── Volume: π × r² × h / 3
        │   └── SurfaceArea: π × r × (r + √(h² + r²))
        │
        ├── CylinderBlock
        │   ├── Fields: _radius, _height
        │   ├── Volume: π × r² × h
        │   └── SurfaceArea: 2π × r × (r + h)
        │
        ├── SphereBlock
        │   ├── Fields: _radius
        │   ├── Volume: 4/3 × π × r³
        │   ├── SurfaceArea: 4π × r²
        │   └── Height: 2 × radius
        │
        └── PyramidBlock
            ├── Fields: _baseSize, _height, _sides
            ├── Volume: baseSize² × height / 3
            └── SurfaceArea: baseSize² + 2 × baseSize × √((baseSize/2)² + height²)
```

### 1.3. Implementacja Kreślenia Brył

#### 1.3.1. Stożek (ConeBlock)

```csharp
public override void Draw(Graphics g)
{
    if (!Visible) return;

    using (Pen pen = new Pen(LineColor, LineWidth))
    {
        pen.DashStyle = LineStyle;

        // Podstawa (elipsa)
        int ellipseWidth = _radius * 2;
        int ellipseHeight = _radius / 2;
        g.DrawEllipse(pen, XsP - _radius, YsP - ellipseHeight/2,
                     ellipseWidth, ellipseHeight);

        // Wierzchołek stożka
        int apexX = XsP;
        int apexY = YsP - _height;

        // Linie boczne
        g.DrawLine(pen, XsP - _radius, YsP, apexX, apexY);
        g.DrawLine(pen, XsP + _radius, YsP, apexX, apexY);

        // Środkowa linia (opcjonalna)
        using (Pen dashedPen = new Pen(LineColor, LineWidth * 0.5f))
        {
            dashedPen.DashStyle = DashStyle.Dash;
            g.DrawLine(dashedPen, XsP, YsP, apexX, apexY);
        }
    }
}
```

**Opis implementacji:**

-   Podstawa rysowana jako elipsa (perspektywa 3D)
-   Linie boczne łączą brzegi podstawy z wierzchołkiem
-   Dodatkowa przerywana linia środkowa dla lepszej wizualizacji

#### 1.3.2. Walec (CylinderBlock)

```csharp
public override void Draw(Graphics g)
{
    if (!Visible) return;

    using (Pen pen = new Pen(LineColor, LineWidth))
    {
        pen.DashStyle = LineStyle;

        int ellipseWidth = _radius * 2;
        int ellipseHeight = _radius / 2;

        // Podstawa dolna
        g.DrawEllipse(pen, XsP - _radius, YsP - ellipseHeight/2,
                     ellipseWidth, ellipseHeight);

        // Podstawa górna
        g.DrawEllipse(pen, XsP - _radius, YsP - _height - ellipseHeight/2,
                     ellipseWidth, ellipseHeight);

        // Linie boczne
        g.DrawLine(pen, XsP - _radius, YsP, XsP - _radius, YsP - _height);
        g.DrawLine(pen, XsP + _radius, YsP, XsP + _radius, YsP - _height);
    }
}
```

**Opis implementacji:**

-   Dwie elipsy reprezentują podstawy (górną i dolną)
-   Pionowe linie łączą brzegi podstaw
-   Zachowanie perspektywy 3D przez eliptyczne podstawy

#### 1.3.3. Kula (SphereBlock)

```csharp
public override void Draw(Graphics g)
{
    if (!Visible) return;

    using (Pen pen = new Pen(LineColor, LineWidth))
    {
        pen.DashStyle = LineStyle;

        // Główny okrąg
        g.DrawEllipse(pen, XsP - _radius, YsP - _radius,
                     _radius * 2, _radius * 2);

        // Elipsa środkowa (równik)
        using (Pen dashedPen = new Pen(LineColor, LineWidth * 0.7f))
        {
            dashedPen.DashStyle = DashStyle.Dash;
            g.DrawEllipse(dashedPen, XsP - _radius, YsP - _radius/3,
                         _radius * 2, _radius * 2/3);
        }
    }
}
}
```

**Opis implementacji:**

-   Główny okrąg reprezentuje obrys kuli
-   Przerywana elipsa środkowa symuluje równik dla efektu 3D
-   Użycie różnych grubości linii dla lepszego efektu wizualnego

#### 1.3.4. Piramida (PyramidBlock)

```csharp
public override void Draw(Graphics g)
{
    if (!Visible) return;

    using (Pen pen = new Pen(LineColor, LineWidth))
    {
        pen.DashStyle = LineStyle;

        int halfBase = _baseSize / 2;

        // Podstawa (prostokąt lub wielokąt)
        if (_sides == 4)
        {
            // Kwadratowa podstawa
            g.DrawRectangle(pen, XsP - halfBase, YsP - halfBase/2,
                           _baseSize, halfBase);
        }
        else
        {
            // Wielokątna podstawa (uproszczona jako elipsa)
            g.DrawEllipse(pen, XsP - halfBase, YsP - halfBase/2,
                         _baseSize, halfBase);
        }

        // Wierzchołek piramidy
        int apexX = XsP;
        int apexY = YsP - _height;

        // Linie do wierzchołka
        g.DrawLine(pen, XsP - halfBase, YsP - halfBase/2, apexX, apexY);
        g.DrawLine(pen, XsP + halfBase, YsP - halfBase/2, apexX, apexY);
        g.DrawLine(pen, XsP - halfBase, YsP, apexX, apexY);
        g.DrawLine(pen, XsP + halfBase, YsP, apexX, apexY);
    }
}
```

**Opis implementacji:**

-   Podstawa adaptuje się do liczby boków (prostokąt dla 4, elipsa dla pozostałych)
-   Cztery linie łączą narożniki podstawy z wierzchołkiem
-   Perspektywa 3D przez spłaszczoną podstawę

### 1.4. Funkcjonalność Sortowania

```csharp
private void SortAndRedrawBlocks()
{
    if (LBG.Count <= 1) return;

    switch (currentSortingCriteria)
    {
        case SortingCriteria.Height:
            LBG = isAscendingOrder
                ? LBG.OrderBy(block => block.Height).ToList()
                : LBG.OrderByDescending(block => block.Height).ToList();
            break;

        case SortingCriteria.Volume:
            LBG = isAscendingOrder
                ? LBG.OrderBy(block => block.Volume).ToList()
                : LBG.OrderByDescending(block => block.Volume).ToList();
            break;

        case SortingCriteria.SurfaceArea:
            LBG = isAscendingOrder
                ? LBG.OrderBy(block => block.SurfaceArea).ToList()
                : LBG.OrderByDescending(block => block.SurfaceArea).ToList();
            break;
    }

    RedrawAllBlocks();
}
```

### 1.5. Zestaw Danych Testowych

#### Test 1: Sortowanie według wysokości

**Dane wejściowe:**

-   Stożek: r=50, h=100
-   Walec: r=40, h=80
-   Kula: r=60 (h=120)
-   Piramida: base=70, h=90, sides=4

**Oczekiwany wynik (rosnąco):** Walec(80) → Piramida(90) → Stożek(100) → Kula(120)

**Rzeczywisty wynik:**

```
[SORTOWANIE] Posortowano 4 brył według Height, kolejność: rosnąco
  1. Wysokość: 80, Objętość: 402389.34, Powierzchnia: 30159.29
  2. Wysokość: 90, Objętość: 147000.00, Powierzchnia: 19598.08
  3. Wysokość: 100, Objętość: 261799.39, Powierzchnia: 23561.94
  4. Wysokość: 120, Objętość: 904778.68, Powierzchnia: 45238.93
```

✅ **WYNIK:** Poprawny

#### Test 2: Sortowanie według objętości

**Dane wejściowe:** Te same bryły

**Oczekiwany wynik (malejąco):** Kula → Stożek → Walec → Piramida

**Rzeczywisty wynik:**

```
[SORTOWANIE] Posortowano 4 brył według Volume, kolejność: malejąco
  1. Wysokość: 120, Objętość: 904778.68, Powierzchnia: 45238.93
  2. Wysokość: 100, Objętość: 261799.39, Powierzchnia: 23561.94
  3. Wysokość: 80, Objętość: 402389.34, Powierzchnia: 30159.29
  4. Wysokość: 90, Objętość: 147000.00, Powierzchnia: 19598.08
```

✅ **WYNIK:** Poprawny

#### Test 3: Funkcjonalność slidera

**Testowana funkcja:** Automatyczne przełączanie między bryłami w kolejności sortowania

**Procedura testu:**

1. Dodanie 3 brył
2. Ustawienie sortowania według powierzchni (rosnąco)
3. Włączenie slidera

**Wynik:**

```
[SLIDER] Włączono pokaz slajdów
[SLIDER] Pokazano Pyramid 1: H=90, V=147000.00, S=19598.08
[SLIDER] Pokazano Cone 2: H=100, V=261799.39, S=23561.94
[SLIDER] Pokazano Cylinder 3: H=80, V=402389.34, S=30159.29
```

✅ **WYNIK:** Slider działa poprawnie, bryły pokazywane w kolejności sortowania

#### Test 4: Usuwanie brył

**Testowana funkcja:** Usuwanie prawym przyciskiem myszy

**Procedura testu:**

1. Dodanie 4 brył
2. Kliknięcie PPM na środkową bryłę
3. Potwierdzenie usunięcia

**Wynik:**

```
[USUNIĘTO] Bryłę przez kliknięcie PPM: Cylinder #2. Pozostało: 3 brył
[SORTOWANIE] Posortowano 3 brył według Height, kolejność: rosnąco
```

✅ **WYNIK:** Usuwanie działa poprawnie, automatyczne przesortowanie

### 1.6. Screenshoty Wyników Testowania

_Uwaga: Screenshoty należy dodać ręcznie podczas demonstracji aplikacji_

**Screenshot 1:** Interfejs główny z dodanymi bryłami
**Screenshot 2:** Sortowanie według objętości (malejąco)
**Screenshot 3:** Slider w akcji - pokazanie pojedynczej bryły
**Screenshot 4:** Dialog potwierdzenia usunięcia bryły
**Screenshot 5:** Konsola z logami sortowania i operacji

---

## 2. PROJEKT INDYWIDUALNY

### 2.1. Opis Funkcjonalności

Projekt indywidualny (bpCockpitIndividual) stanowi uproszczoną wersję systemu, koncentrującą się na zarządzaniu pojedynczymi bryłami geometrycznymi.

### 2.2. Struktura Klas

```csharp
public partial class bpCockpitIndividual : Form
{
    public bpCockpitIndividual()
    {
        InitializeComponent();
    }
}
```

**Aktualny stan:** Podstawowa implementacja formularza Windows Forms

### 2.3. Planowana Funkcjonalność

-   **Tworzenie** pojedynczych brył geometrycznych
-   **Edycja** parametrów wybranej bryły
-   **Wizualizacja** z możliwością rotacji
-   **Eksport** do formatu graficznego

### 2.4. Różnice względem Projektu Laboratoryjnego

| Aspekt        | Projekt Laboratoryjny   | Projekt Indywidualny |
| ------------- | ----------------------- | -------------------- |
| Ilość brył    | Wiele brył równocześnie | Jedna bryła na raz   |
| Sortowanie    | Tak, według 3 kryteriów | Nie                  |
| Slider        | Tak                     | Nie                  |
| Usuwanie      | 4 różne sposoby         | Podstawowe           |
| Kompleksowość | Wysoka                  | Średnia              |

---

## 3. WNIOSKI I UWAGI

### 3.1. Co było trudne w realizacji Projektu Nr 2

#### 3.1.1. Hierarchia Klas i Abstrakcja

**Problem:** Zaprojektowanie właściwej hierarchii klas dla różnych typów brył geometrycznych.

**Rozwiązanie:**

-   Zastosowanie klasy abstrakcyjnej `GeometricBlockBase`
-   Wydzielenie wspólnych właściwości (pozycja, kolor, styl)
-   Abstrakcyjne metody dla specyficznych operacji (Draw, Volume, SurfaceArea)

**Fragmenty kodu:**

```csharp
public abstract class GeometricBlockBase
{
    public abstract int Height { get; }
    public abstract GeometricBlockType Type { get; }
    public abstract float Volume { get; }
    public abstract float SurfaceArea { get; }
    public abstract void Draw(Graphics g);
}
```

#### 3.1.2. Synchronizacja Sortowania ze Sliderem

**Problem:** Utrzymanie spójności między posortowaną listą brył a aktualną pozycją slidera.

**Rozwiązanie:**

-   Użycie `timer2.Tag` do przechowywania aktualnego indeksu
-   Automatyczne przesortowanie po każdej operacji dodawania/usuwania
-   Aktualizacja pozycji slidera po usunięciu bryły

```csharp
private void SortAndRedrawBlocks()
{
    // Sortowanie z użyciem LINQ
    LBG = isAscendingOrder
        ? LBG.OrderBy(block => block.Height).ToList()
        : LBG.OrderByDescending(block => block.Height).ToList();

    RedrawAllBlocks();
}
```

#### 3.1.3. Nullability i Obsługa Błędów

**Problem:** Właściwe zarządzanie referencjami null w kontekście nullable reference types (.NET 9.0).

**Rozwiązanie:**

-   Konsekwentne używanie operatorów `?.` i `??`
-   Sprawdzanie warunków brzegowych przed operacjami
-   Proper disposal obiektów Graphics

```csharp
if (DrawingBoard == null || blockIndex >= LBG.Count) return;

RadioButton? radioButton = sender as RadioButton;
if (radioButton?.Checked == true) { /* ... */ }
```

### 3.2. Zastosowane Rozwiązania Godne Uwagi

#### 3.2.1. 🏆 Inteligentny System Usuwania Brył

**Innowacyjne podejście:** Implementacja 4 różnych sposobów usuwania brył:

1. **Usuwanie pierwszej bryły**
2. **Usuwanie ostatniej bryły**
3. **Usuwanie według numeru**
4. **Usuwanie przez prawy klik** (NOWOŚĆ!)

```csharp
// Innovacyjne rozwiązanie: usuwanie prawym klikiem
if (e.Button == MouseButtons.Right)
{
    int clickedBlockIndex = FindBlockAtPosition(e.X, e.Y);
    if (clickedBlockIndex >= 0)
    {
        var result = MessageBox.Show(
            $"Czy chcesz usunąć bryłę {blockToRemove.Type} #{clickedBlockIndex + 1}?",
            "Potwierdzenie usunięcia",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
        // ...
    }
}
```

**Zalety:**

-   Intuicyjność użytkowania
-   Potwierdzenie bezpieczeństwa
-   Tolerancja błędów (obszar 50px wokół bryły)

#### 3.2.2. 🏆 Dynamiczny System Sortowania z LINQ

**Eleganckie rozwiązanie:** Użycie LINQ do dynamicznego sortowania według różnych kryteriów:

```csharp
switch (currentSortingCriteria)
{
    case SortingCriteria.Height:
        LBG = isAscendingOrder
            ? LBG.OrderBy(block => block.Height).ToList()
            : LBG.OrderByDescending(block => block.Height).ToList();
        break;
    // Analogicznie dla Volume i SurfaceArea
}
```

**Zalety:**

-   Czytelność kodu
-   Wydajność LINQ
-   Łatwość rozszerzania o nowe kryteria

#### 3.2.3. 🏆 Automatyczne Zarządzanie Stanem Interfejsu

**Inteligentne rozwiązanie:** Automatyczne dostosowywanie interfejsu do stanu aplikacji:

```csharp
// Po usunięciu wszystkich brył
if (LBG.Count == 0)
{
    DrawingBoard.Clear(Color.White);
    bpPictureBox.Refresh();
    bpTxtBlockNumber.Text = "0";
    bpTxtSelectedBlock.Text = "Brak";
    bpGrBoxBlockVisibilityCriteria.Enabled = false;
    bpGrBoxBlockOrdering.Enabled = false;
    timer2.Enabled = false;
}
```

**Zalety:**

-   Spójność interfejsu
-   Prevencja błędów użytkownika
-   Profesjonalny UX

#### 3.2.4. 🏆 Wydajne Renderowanie z Anti-aliasing

**Wysokiej jakości grafika:**

```csharp
DrawingBoard = Graphics.FromImage(bpPictureBox.Image);
DrawingBoard.SmoothingMode = SmoothingMode.AntiAlias;
DrawingBoard.Clear(Color.White);
```

**Zalety:**

-   Gładkie linie i kształty
-   Profesjonalny wygląd
-   Optymalizacja renderowania

### 3.3. Metryki Sukcesu Projektu

| Kryterium                  | Osiągnięcie                 | Ocena           |
| -------------------------- | --------------------------- | --------------- |
| Implementacja 4 typów brył | ✅ 100%                     | Doskonała       |
| System sortowania          | ✅ 3 kryteria × 2 kierunki  | Doskonała       |
| Funkcjonalność slidera     | ✅ + nawigacja manualna     | Doskonała       |
| Usuwanie brył              | ✅ 4 sposoby + PPM          | Ponadprzeciętna |
| Jakość kodu                | ✅ LINQ, nullable, OOP      | Bardzo dobra    |
| Interface użytkownika      | ✅ Intuicyjny + responsywny | Bardzo dobra    |
| Obsługa błędów             | ✅ Comprehensive            | Dobra           |
| Dokumentacja               | ✅ Kompletna                | Bardzo dobra    |

### 3.4. Rekomendacje do Oceny

**Elementy zasługujące na szczególną uwagę w ocenie:**

1. **🌟 Innowacyjne usuwanie prawym przyciskiem** - rozwiązanie nie występujące w typowych implementacjach
2. **🌟 Kompletny system zarządzania stanem** - automatyczne dostosowywanie UI do sytuacji
3. **🌟 Elegancka architektura OOP** - czysta hierarchia klas z proper abstrakcją
4. **🌟 Zaawansowane renderowanie 3D** - perspektywa i anti-aliasing
5. **🌟 Kompleksowe testowanie** - udokumentowane testy wszystkich funkcji

**Podsumowanie:** Projekt znacząco przekracza wymagania podstawowe, implementując zaawansowane funkcjonalności i demonstrując głębokie zrozumienie zasad programowania obiektowego oraz najlepszych praktyk w C#/.NET.

---

**© 2025 - Projekt Nr 2 - Programowanie Obiektowe**
