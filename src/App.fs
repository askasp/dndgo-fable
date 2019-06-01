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
open Fable.MaterialUI.Props
open Fable.FontAwesome
open Fable.MaterialUI
open Fable.MaterialUI.Props
open Fable.MaterialUI.Props

module MyIcon = Fable.MaterialUI.Icons

// MODEL

let primaryString = "rgba(255,255,255,0.87)"
let secondaryString = "rgba(255,255,255,0.60)"


               
type Model = {collapse:string}
type Msg = Toggle of string


let init() : Model = {collapse= ""}

// UPDATE

let update (msg:Msg) (model:Model)  =
    match msg with
    |Toggle result when model.collapse =result -> {model with collapse = ""}
    |Toggle result ->  {model with collapse = result}
    | _ ->  {collapse=""}

// VIEW (rendered with React)

let myListItem (model:Model) (key:string) (icon:Fa.IconOption) (value:string) (collapsContent:ReactElement) dispatch=
  div[][
    Mui.listItem[ListItemProp.Button true
                 OnClick (fun _ -> key |> Toggle |>dispatch )
                 Style[unbox("color",secondaryString)
                       unbox("fontFamily","Roboto")
                       ]][
    Mui.listItemIcon[Style [unbox("color",secondaryString)]][
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
    ]


let mylistSubHeader (title:string) = 
    Mui.listSubheader[MaterialProp.Component ("div"|> ReactElementType.ofHtmlElement)
                      Style[
                          unbox ("color", "rgba(255,255,255,0.60)")
                          unbox ("textAlign", "center")
                      ]][str title]

let cardview (model:Model) dispatch =
    Mui.grid[
        GridProp.Container true
        GridProp.Spacing  (GridSpacing.``0`` )
        GridProp.Justify GridJustify.Center
        Style [MinHeight "100vh"
               Display DisplayOptions.Flex
               ]
    ] [
        Mui.grid[ GridProp.Item true
                  GridProp.Xs (GridSizeNum.``12`` |> GridSize.Case3) 
                  GridProp.Md (GridSizeNum.``3`` |> GridSize.Case3)]
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
        Mui.grid[ GridProp.Item true
                  GridProp.Xs (GridSizeNum.``12`` |> GridSize.Case3) 
                  GridProp.Md (GridSizeNum.``4`` |> GridSize.Case3) 
    ]    [
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
        

let view (model:Model) dispatch =

  div [
        Style [BackgroundColor "#121212"
               unbox ("padding","16px")
               unbox("fontFamily","Roboto")
               ]
                
      ]
      [ 
        cardview model dispatch]

// App
Program.mkSimple init update view
|> Program.withReact "elmish-app"
|> Program.withConsoleTrace
|> Program.run
