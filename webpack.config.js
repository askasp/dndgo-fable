// Note this only includes basic configuration for development mode.
// For a more comprehensive configuration check:
// https://github.com/fable-compiler/webpack-config-template

var path = require("path");

//var t = require("./src/App.css");


module.exports = {
    mode: "development",
    entry: ["./src/App.fsproj","./src/App.css"],
//entry:{
    //app: ["./src/App.fsproj"]
//},
    output: {
        path: path.join(__dirname, "./public"),
        filename: "bundle.js",
    },
    devServer: {
        contentBase: "./public",
        port: 8080,
    },
    module: {
        rules: [{
            test: /\.fs(x|proj)?$/,
            use: "fable-loader"
        },
 {
				test: /\.(sass|scss|css)$/,
				use: [
				    'style-loader',
					'css-loader',
					'sass-loader',
				],
			},
        ]
    }
}