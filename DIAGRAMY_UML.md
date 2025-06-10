# DIAGRAMY UML - PROJEKT NR 2

## Diagram Klas - Hierarchia GeometricBlock

```
┌─────────────────────────────────────┐
│           GeometricBlock            │
│                                     │
│  ┌─────────────────────────────────┐│
│  │      GeometricBlockType         ││
│  │         (enum)                  ││
│  │                                 ││
│  │  + Cone                         ││
│  │  + Cylinder                     ││
│  │  + Sphere                       ││
│  │  + Pyramid                      ││
│  └─────────────────────────────────┘│
│                                     │
│  ┌─────────────────────────────────┐│
│  │    GeometricBlockBase           ││
│  │    (abstract class)             ││
│  │                                 ││
│  │  + XsP : int                    ││
│  │  + YsP : int                    ││
│  │  + LineColor : Color            ││
│  │  + LineStyle : DashStyle        ││
│  │  + LineWidth : float            ││
│  │  + Visible : bool               ││
│  │                                 ││
│  │  + Height : int {abstract}      ││
│  │  + Type : GeometricBlockType    ││
│  │          {abstract}             ││
│  │  + Volume : float {abstract}    ││
│  │  + SurfaceArea : float          ││
│  │               {abstract}        ││
│  │                                 ││
│  │  + Draw(g: Graphics)            ││
│  │         {abstract}              ││
│  │  + Erase(g: Graphics,           ││
│  │          control: Control)      ││
│  │         {abstract}              ││
│  │  + Move(g: Graphics,            ││
│  │         control: Control,       ││
│  │         x: int, y: int)         ││
│  │         {abstract}              ││
│  │  + Rotate(g: Graphics,          ││
│  │           control: Control,     ││
│  │           angle: int)           ││
│  │         {abstract}              ││
│  └─────────────────────────────────┘│
└─────────────────────────────────────┘
                    │
                    │ inherits
           ┌────────┼────────┐
           │        │        │
           ▼        ▼        ▼
    ┌─────────┐ ┌─────────┐ ┌─────────┐
    │         │ │         │ │         │
    ▼         ▼ ▼         ▼ ▼         ▼
┌─────────┐ ┌─────────┐ ┌─────────┐ ┌─────────┐
│ConeBlock│ │Cylinder │ │ Sphere  │ │Pyramid  │
│         │ │ Block   │ │ Block   │ │ Block   │
│         │ │         │ │         │ │         │
│-_radius │ │-_radius │ │-_radius │ │-_base   │
│-_height │ │-_height │ │         │ │ Size    │
│-_rotati │ │         │ │         │ │-_height │
│ onAngle │ │         │ │         │ │-_sides  │
│         │ │         │ │         │ │         │
│+Volume  │ │+Volume  │ │+Volume  │ │+Volume  │
│ π×r²×h/3│ │ π×r²×h  │ │4π×r³/3  │ │b²×h/3   │
│         │ │         │ │         │ │         │
│+Surface │ │+Surface │ │+Surface │ │+Surface │
│ Area    │ │ Area    │ │ Area    │ │ Area    │
│π×r×(r+√)│ │2π×r×    │ │ 4π×r²   │ │b²+2b×√  │
│         │ │ (r+h)   │ │         │ │         │
│         │ │         │ │         │ │         │
│+Height  │ │+Height  │ │+Height  │ │+Height  │
│ _height │ │ _height │ │ 2×radius│ │ _height │
│         │ │         │ │         │ │         │
│+Draw()  │ │+Draw()  │ │+Draw()  │ │+Draw()  │
│+Erase() │ │+Erase() │ │+Erase() │ │+Erase() │
│+Move()  │ │+Move()  │ │+Move()  │ │+Move()  │
│+Rotate()│ │+Rotate()│ │+Rotate()│ │+Rotate()│
└─────────┘ └─────────┘ └─────────┘ └─────────┘
```

## Diagram Sekwencji - Dodawanie Bryły

```
User          Form              GeometricBlock    Graphics      Timer
 │              │                     │             │            │
 │──Click(x,y)──>                     │             │            │
 │              │                     │             │            │
 │              │──FillEllipse────────>             │            │
 │              │   (red marker)                    │            │
 │              │                     │             │            │
 │──Click Add───>                     │             │            │
 │              │                     │             │            │
 │              │──new ConeBlock──────>             │            │
 │              │                     │             │            │
 │              │                     │──Draw()─────>            │
 │              │                     │             │            │
 │              │──Add to LBG[]       │             │            │
 │              │                     │             │            │
 │              │──SortAndRedraw()    │             │            │
 │              │                     │             │            │
 │              │────────────────────────────────────────Enable──>
 │              │                     │             │            │
 │<─Display─────                      │             │            │
```

## Diagram Aktywności - Sortowanie Brył

```
                    ┌─────────────────┐
                    │   User clicks   │
                    │ sorting option  │
                    └─────────┬───────┘
                              │
                              ▼
                    ┌─────────────────┐
                    │ OnSortingChanged│
                    │    triggered    │
                    └─────────┬───────┘
                              │
                              ▼
                    ┌─────────────────┐      ┌────────────────┐
                    │   LBG.Count     │ No   │     Return     │
                    │     <= 1?       ├─────>│   (no action)  │
                    └─────────┬───────┘      └────────────────┘
                              │ Yes
                              ▼
                    ┌─────────────────┐
                    │  Switch on      │
                    │ SortingCriteria │
                    └─────────┬───────┘
                              │
                   ┌──────────┼──────────┐
                   │          │          │
                   ▼          ▼          ▼
           ┌─────────────┐ ┌─────────────┐ ┌─────────────┐
           │   Height    │ │   Volume    │ │ SurfaceArea │
           │  Sorting    │ │  Sorting    │ │  Sorting    │
           └─────────────┘ └─────────────┘ └─────────────┘
                   │          │          │
                   └──────────┼──────────┘
                              │
                              ▼
                    ┌─────────────────┐
                    │  isAscending?   │
                    └─────────┬───────┘
                              │
                   ┌──────────┼──────────┐
                   │ Yes      │       No │
                   ▼          ▼          ▼
           ┌─────────────┐         ┌─────────────┐
           │   OrderBy   │         │OrderByDesc  │
           │   (LINQ)    │         │   (LINQ)    │
           └─────────────┘         └─────────────┘
                   │                       │
                   └───────────┬───────────┘
                               │
                               ▼
                    ┌─────────────────┐
                    │ RedrawAllBlocks │
                    └─────────┬───────┘
                              │
                              ▼
                    ┌─────────────────┐
                    │  Update Display │
                    └─────────────────┘
```

## Diagram Stanu - Lifecycle Bryły

```
    ┌─────────────┐
    │   Initial   │
    │   (null)    │
    └─────┬───────┘
          │ User clicks position
          ▼
    ┌─────────────┐
    │ Position    │
    │  Selected   │
    │ (red dot)   │
    └─────┬───────┘
          │ User clicks "Add Block"
          ▼
    ┌─────────────┐
    │  Created    │
    │ (in memory) │
    └─────┬───────┘
          │ Add to LBG[]
          ▼
    ┌─────────────┐
    │   Visible   │     ┌─────────────┐
    │ (rendered)  │────>│  Sorting    │
    └─────┬───────┘     │ (reorder)   │
          │             └─────┬───────┘
          │ User interaction         │
          ▼                          │
    ┌─────────────┐                  │
    │  Selected   │                  │
    │ (in slider) │<─────────────────┘
    └─────┬───────┘
          │ User removes
          ▼
    ┌─────────────┐
    │   Removed   │
    │ (destroyed) │
    └─────────────┘
```

## Diagram Przypadków Użycia

```
                     ┌─────────────────────────────────────┐
                     │           System Brył               │
                     │                                     │
     ┌──────────┐    │   ┌─────────────────────────────┐   │
     │          │    │   │      Add Shape              │   │
     │          │────┼───>  • Click position          │   │
     │          │    │   │  • Select type             │   │
     │          │    │   │  • Set parameters          │   │
     │          │    │   │  • Click "Add"             │   │
     │   User   │    │   └─────────────────────────────┘   │
     │          │    │                                     │
     │          │    │   ┌─────────────────────────────┐   │
     │          │────┼───>      Sort Shapes            │   │
     │          │    │   │  • Select criteria         │   │
     │          │    │   │  • Choose order            │   │
     │          │    │   └─────────────────────────────┘   │
     │          │    │                                     │
     │          │    │   ┌─────────────────────────────┐   │
     │          │────┼───>     Use Slider              │   │
     │          │    │   │  • Start/Stop              │   │
     │          │    │   │  • Navigate manually       │   │
     │          │    │   └─────────────────────────────┘   │
     │          │    │                                     │
     │          │    │   ┌─────────────────────────────┐   │
     │          │────┼───>    Remove Shapes            │   │
     │          │    │   │  • Button remove           │   │
     │          │    │   │  • Right-click remove      │   │
     │          │    │   └─────────────────────────────┘   │
     │          │    │                                     │
     └──────────┘    └─────────────────────────────────────┘
```

## Diagram Komponentów - Architektura Systemu

```
┌─────────────────────────────────────────────────────────────┐
│                    Windows Forms Layer                      │
│  ┌─────────────────┐  ┌─────────────────┐  ┌─────────────── │
│  │   bpCockpit     │  │bpCockpitLabor   │  │bpCockpitIndiv │
│  │   (Main Menu)   │  │   (Main App)    │  │  (Individual) │
│  └─────────────────┘  └─────────────────┘  └─────────────── │
└─────────────────────────────────────────────────────────────┘
                                  │
                                  ▼
┌─────────────────────────────────────────────────────────────┐
│                    Business Logic Layer                     │
│  ┌─────────────────────────────────────────────────────────┐│
│  │                 GeometricBlock                         ││
│  │                                                        ││
│  │  ┌─────────────────┐  ┌─────────────────────────────┐  ││
│  │  │GeometricBlock   │  │     GeometricBlockBase      │  ││
│  │  │     Type        │  │    (Abstract Class)        │  ││
│  │  │   (Enum)        │  │                             │  ││
│  │  └─────────────────┘  └─────────────────────────────┘  ││
│  │                                  │                     ││
│  │         ┌────────────────────────┼────────────────────┐││
│  │         │        │               │               │    ││
│  │         ▼        ▼               ▼               ▼    ││
│  │  ┌─────────┐ ┌─────────┐ ┌─────────┐ ┌─────────┐     ││
│  │  │ Cone    │ │Cylinder │ │ Sphere  │ │Pyramid  │     ││
│  │  │ Block   │ │ Block   │ │ Block   │ │ Block   │     ││
│  │  └─────────┘ └─────────┘ └─────────┘ └─────────┘     ││
│  └─────────────────────────────────────────────────────────┘│
└─────────────────────────────────────────────────────────────┘
                                  │
                                  ▼
┌─────────────────────────────────────────────────────────────┐
│                   Graphics & Rendering Layer                │
│  ┌─────────────────────────────────────────────────────────┐│
│  │              System.Drawing                            ││
│  │                                                        ││
│  │  ┌─────────────┐ ┌─────────────┐ ┌─────────────┐      ││
│  │  │  Graphics   │ │   Bitmap    │ │    Pen      │      ││
│  │  │   Engine    │ │   Buffer    │ │   Styles    │      ││
│  │  └─────────────┘ └─────────────┘ └─────────────┘      ││
│  └─────────────────────────────────────────────────────────┘│
└─────────────────────────────────────────────────────────────┘
```

## Diagram Przepływu Danych - Sortowanie

```
[User Input]
     │
     ▼
[Radio Button]──────> [Event Handler]
     │                       │
     ▼                       ▼
[Criteria Selection]   [OnSortingChanged()]
     │                       │
     ▼                       ▼
[currentSortingCriteria] [SortAndRedrawBlocks()]
     │                       │
     ▼                       ▼
[LINQ OrderBy/OrderByDesc]   │
     │                       │
     ▼                       ▼
[Sorted LBG List]     [RedrawAllBlocks()]
     │                       │
     ▼                       ▼
[Updated UI Display]  [Graphics.Clear()]
     │                       │
     ▼                       ▼
[User sees result]    [Draw each block]
                            │
                            ▼
                      [PictureBox.Refresh()]
```
