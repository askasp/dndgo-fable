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
open System.Drawing
open Fable.MaterialUI.Props
open Fable.MaterialUI.Props
open Fable.MaterialUI.Props
open Fable.MaterialUI.Props
open Fable.MaterialUI.Props
open Fable.MaterialUI.Props
open Fable.MaterialUI.Props
open Fable.MaterialUI.Props
open Fable.MaterialUI.Props
open Fable.MaterialUI.Props
open Fable.MaterialUI.Themes
open Fable.MaterialUI.Themes
open Fable.React
open Fable.FontAwesome
open Fable.FontAwesome.Free
open Fable.MaterialUI.Props
open Fable.React.Props

// MODEL


type Model = int

type Msg =
| Increment
| Decrement

let init() : Model = 0

// UPDATE

let update (msg:Msg) (model:Model) =
    match msg with
    | Increment -> model + 1
    | Decrement -> model - 1

// VIEW (rendered with React)

let cardview (model:Model) =
    Mui.grid[
        GridProp.Container true
        //GridProp.Spacing  (GridSpacing.``8``)
        GridProp.Justify GridJustify.Center
        Style [MinHeight "100vh"
               Display DisplayOptions.Flex
               ]
    ] [
        Mui.grid[ GridProp.Item true
                  GridProp.Xs (GridSizeNum.``12`` |> GridSize.Case3) 
                  //GridProp.Md (GridSizeNum.``12`` |> GridSize.Case3) 
    ][
        Mui.list[
            MaterialProp.Component ("nav" |>ReactElementType.ofHtmlElement)
            Style [Width "100%"
                   ]][
            Mui.card[Style[BackgroundColor "#1e1e1e"]][
                Mui.cardContent[][
                    Mui.listSubheader[MaterialProp.Component ("div"|> ReactElementType.ofHtmlElement)
                                      Style[
                                          unbox ("color", "white")
                                          unbox ("textAlign", "center")
                                      ]][str "Stats"]
                    Mui.listItem[ListItemProp.Button true
                                 Style[unbox("color","#ffffff")]][
                    Mui.listItemIcon[Style [unbox("color","white")]][
                                                                     Fa.i[Fa.Solid.Heart
                                                                          ][]]
                    Mui.listItemText[ListItemTextProp.Primary (str "hei")][]
                    ]
                ]
            ]
        ]
            
        ]]
        

let view (model:Model) dispatch =

  div [
        Style [BackgroundColor "#121212"
               unbox ("padding","16px")
               ]
      ]
      [ 
        cardview model]

// App
Program.mkSimple init update view
|> Program.withReact "elmish-app"
|> Program.withConsoleTrace
|> Program.run
