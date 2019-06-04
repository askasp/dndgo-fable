module App

(**
 The famous Increment/Decrement ported from Elm.
 You can find more info about Elmish architecture and samples at https://elmish.github.io/
*)

open Elmish
open Elmish.React
open Fable.React
open Fable.React.Props
module Mui = Fable.MaterialUI.Core
open Fable.Core
open Fable.MaterialUI.Props
open Fable.FontAwesome
open Fable.MaterialUI
open Fable.MaterialUI.Props
open Fable.MaterialUI.Props
open Fable.MaterialUI.Props
open Fable.MaterialUI.Themes
open Fable.MaterialUI.Themes

module MyIcon = Fable.MaterialUI.Icons

//STYLES
let primaryString = "rgba(255,255,255,0.87)"
let secondaryString = "rgba(255,255,255,0.60)"
//let primaryColor = "#ffab91"
let primaryColor = "#03dac5"
let cardContentStyle = Style[BackgroundColor "#1e1e1e"]
let fabStyle =Style[
    BackgroundColor primaryColor
    unbox("margin","8px")
    unbox("color","black")
]
let gridContainerStyle =
        GridProp.Container true
        GridProp.Spacing  GridSpacing.``0``
        GridProp.Justify GridJustify.Center
        Style [MinHeight "100vh"
               ]
        
let gridItemStyle=
          GridProp.Item true
          GridProp.Xs (GridSizeNum.``12`` |> GridSize.Case3) 
          GridProp.Md (GridSizeNum.``4`` |> GridSize.Case3)
                
let mainStyle = 
        Style [BackgroundColor "#121212"
               FlexGrow 1
               MinHeight "100vh"
               unbox("fontFamily","Roboto")
               unbox("width","100vw")
               unbox("position","absolute")
               unbox("left","0")
               unbox("top","0")
               unbox("overflow","auto")
               
               ]

///
/// MODEL

type Page  = Home | CreateCharacter | Character
               
type Model = {collapse:string;ActivePage:Page}
type Msg = Toggle of string
           |SetPage of Page

let init() : Model = {collapse= "";ActivePage=Home}

// UPDATE

let update (msg:Msg) (model:Model)  =
    match msg with
    |SetPage apage -> {model with ActivePage = apage}
    |Toggle result when model.collapse =result -> {model with collapse = ""}
    |Toggle result ->  {model with collapse = result}
    | _ ->  {model with collapse=""}

// VIEW (rendered with React)

let homePage (model:Model) dispatch=
    Mui.card[ClassName "card"
             Style[unbox("text-align","center")]][
                Mui.cardContent[cardContentStyle][
                Mui.typography[TypographyProp.Variant TypographyVariant.H5
                               Style[unbox("color",primaryString)]
                               ][str "DnDGo"]
                Mui.typography[TypographyProp.Variant TypographyVariant.Body1
                               Style[unbox("color",primaryString)]][str "Import an existing character from the burger menu or..."]
                ]
                div[Style[BackgroundColor "#1e1e1e"]][
                Mui.fab[fabStyle
                        FabProp.Variant FabVariant.Extended
                        OnClick  ( fun _ -> Character|> SetPage |>dispatch)
                        ][
                         Fa.i[Fa.Solid.Plus][]
                         str "Create new"
                ]
                ]
    ]
        

let MyDivider =
    hr[Style[Opacity 0.05]]

let myAppBar (model:Model) dispatch =
    div[Style[FlexGrow 1]][
        Mui.appBar[AppBarProp.Position AppBarPosition.Static
                   Style [BackgroundColor "#2e2e2e"]][
            Mui.toolbar[][
                Mui.iconButton[Style[unbox("color",secondaryString)]][
                    Fa.i[Fa.Size Fa.FaExtraSmall
                         Fa.Solid.Bars][]
                ]
                Mui.typography[
                                TypographyProp.Variant TypographyVariant.H6
                                TypographyProp.NoWrap true
                                Style[FlexGrow 1
                                      Display DisplayOptions.Block
                                      unbox("color",primaryString)]][str "Oblag 10"]
                
                div[ClassName "search"][
                    div[ClassName "searchIcon"][
                        Fa.i[Fa.Solid.Search][]
                    ]
                    Mui.inputBase[
                                  MaterialProp.Classes[
                                    ClassNames.Root "inputRoot"
                                    ClassNames.Input "inputInput"
                                  ]
                                  Placeholder "Search.."
                                        ]
                ]
            ]
        ]
    ]
    

let myListItem (model:Model) (key:string) (icon:Fa.IconOption) (value:string) (collapsContent:ReactElement) dispatch=
  div[][
    Mui.listItem[ListItemProp.Button true
                 OnClick (fun _ -> key |> Toggle |>dispatch )
                 Style[unbox("color",primaryString)
                       unbox("fontFamily","Roboto")
                       ]][
    Mui.listItemIcon[Style [unbox("color",primaryColor)]][
                                                     Fa.i[icon
                                                          ][]]
    Mui.listItemText[ListItemTextProp.Primary (str value)][]
    (if model.collapse = key then
        Icons.expandLessIcon[]
    else
        Icons.expandMoreIcon[]
    )
    ]
    Mui.collapse[MaterialProp.In (model.collapse =  key) ][
        Mui.list[
            MaterialProp.Component ("div" |>ReactElementType.ofHtmlElement)
            DisablePadding true
            Style[MarginLeft "32px"
                  unbox ("color",secondaryString)]
            ][
            collapsContent
        ]
        ]
    MyDivider
    ]


let mylistSubHeader (title:string) = 
    Mui.listSubheader[MaterialProp.Component ("div"|> ReactElementType.ofHtmlElement)
                      Style[
                          unbox ("color", "rgba(255,255,255,0.60)")
                          unbox ("textAlign", "center")
                      ]][str title]


let characterPage (model:Model) dispatch =
    Mui.grid[gridContainerStyle][
        Mui.grid[gridItemStyle]
                [Mui.list[
                MaterialProp.Component ("nav" |>ReactElementType.ofHtmlElement)
                Style [Width "100%"
                       ]][
                Mui.card[Style[BackgroundColor "#1e1e1e"]][
                    Mui.cardContent[][
                        mylistSubHeader "Stats"
                        myListItem model "Ac1" Fa.Solid.Heart "HP 30/100" (str "hei") dispatch
                        myListItem model "Ac2" Fa.Solid.ShieldAlt "AC 16" (str "hei") dispatch
                        myListItem model "Ac3" Fa.Solid.Dice "Hit Die 5d12" (str "hei") dispatch
                        myListItem model "Ac4" Fa.Solid.Running "Speed 30" (str "hei") dispatch
                        myListItem model "Ac5" Fa.Solid.Lightbulb "Initiative 5" (str "hei") dispatch
                        myListItem model "Ac6" Fa.Solid.Shapes "Profficiency 4" (str "hei") dispatch
                        
                    ]
                 ]
              ]
        ]
        Mui.grid[ gridItemStyle][
            Mui.list[
                MaterialProp.Component ("nav" |>ReactElementType.ofHtmlElement)
                Style [Width "100%"
                       ]][
                Mui.card[Style[BackgroundColor "#1e1e1e"]][
                    Mui.cardContent[][
                    mylistSubHeader "Attributes"
                    myListItem model "Ac7" Fa.Solid.Dumbbell "STR:16" (str "hei") dispatch
                    myListItem model "Ac8" Fa.Solid.Pills "Constitution 16" (str "hei") dispatch
                    myListItem model "Ac9" Fa.Solid.Cat "Dexterity 16" (str "hei") dispatch
                    myListItem model "Ac10" Fa.Solid.HatWizard "INT:10" (str "hei") dispatch
                    myListItem model "Ac11" Fa.Solid.Book "WIS: 5" (str "hei") dispatch
                    myListItem model "Ac12" Fa.Solid.LaughBeam "CHA: 4" (str "hei") dispatch
                    ]
                ]
                ]
        ]
        ]
    
let createCharacterPage =
     Mui.grid[gridContainerStyle][
         Mui.grid[gridItemStyle][
             Mui.textField[
                 MaterialProp.Label (str "Name")
             ][
                 
             ]
         ]
     ]
    
    
 
    
        
let currentPageView (model:Model) dispatch =
    match model.ActivePage with
    |Home -> homePage model dispatch
    |Character -> characterPage model dispatch

let view (model:Model) dispatch =

  div [mainStyle
      ]
      [
        myAppBar model dispatch
        div[Style[unbox("padding","16px")]][
         createCharacterPage
         currentPageView model dispatch
        ]
//        cardview model dispatch]
]

     
// App
Program.mkSimple init update view
|> Program.withReact "elmish-app"
|> Program.withConsoleTrace
|> Program.run
