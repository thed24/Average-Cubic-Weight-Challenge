# Average Cubic Weight Challenge

## Challenge Description
Using the provided (paginated) API, find the average cubic weight for all products in the "Air Conditioners" category.

Cubic weight is calculated by multiplying the length, height and width of the parcel. The result is then multiplied by the industry standard cubic weight conversion factor of 250.

## Assumptions

The challenge description noted that the tool should be able to *handle large input efficiently*, however both *large* and *efficiently* were not quantified with metrics. In-order to test these factors, some form of performance tests or benchmarking should be utilised, however these seem out of scope for the scale of the challenge. Furthermore, the intensive operations within this application would largely be either the request handling or the JSON serialization which are both abstracted by powerful frameworks. As such, it is assumed that performance testing the aforementioned criteria is not required for this challenge.

The challenge also dictates that the program should perform one function and one function only, which is finding the average cubic weight of all air conditioner products. From this, it was assumed that handling user input and other categories could be ignored, and as such on running the program the output is simply printed to the screen. That being said, the code was still written with the intent to decouple as many of these concerns as possible so that it would be easily *open for extension* if needed.
## How To Run

The tool is simple to use, and simply requires an installation of the DotNet Core SDK compatible with DotNet Core 3.1. This can be installed via Brew for Mac, or the installation tool on the Microsoft website. Once it's installed, follow the instructions below to run either the tests or the tool.

To run the test suite, please issue the following commands from the root directory:

```
cd Tests
dotnet test
```

To run the CLI tool, please issue the following commands from the root directory:

```
cd Application
dotnet run
```

To obtain this repo / project, either use Git to clone the repo, or download the zipped source code from the releases section in GitHub.

## Example Payload From API:

```
{
    "objects": [
        {
            "category": "Air Conditioners",
            "title": "Fancy Aircon",
            "weight": 33500.0,
            "size": {
                "width": 49.5,
                "length": 56.7,
                "height": 87.5
            }
        },
        {
            "category": "Air Conditioners",
            "title": "Fancier Aircon",
            "weight": 35450.0,
            "size": {
                "width": 49.5,
                "length": 56.8,
                "height": 87.5
            }
        },
        {
            "category": "LED Televisions",
            "title": "Smart TV",
            "weight": 8100.0,
            "size": {
                "width": 53.7,
                "length": 80.0,
                "height": 15.4
            }
        },
        {
            "category": "LED Televisions",
            "title": "Smarter TV",
            "weight": 6700.0,
            "size": {
                "width": 13.7,
                "length": 80.2,
                "height": 50.5
            }
        },
        {
            "category": "LED Televisions",
            "title": "Smartest TV",
            "weight": 7380.0,
            "size": {
                "width": 16.5,
                "length": 80.0,
                "height": 51.0
            }
        }
    ],
    "next": "/api/products/nextId"
}
```
