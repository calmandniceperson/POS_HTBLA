package main

import (
	"fmt"
	"math"
)

func main() {
	print("Enter number of elements to be inserted into the hash tree: ")

	var elemCount int
	_, err := fmt.Scanf("%d", &elemCount)
	if err != nil {
		panic(err.Error())
	}

	layerCount := int(math.Ceil(math.Log2(float64(elemCount)) + 1))
	nodeCount := int(math.Ceil(math.Pow(2, (float64(layerCount+1))) - 1))

	fmt.Printf("Number of elements: %d\nNumber of layers: %d\nNumber of nodes: %d\n", elemCount, layerCount, nodeCount)
}
