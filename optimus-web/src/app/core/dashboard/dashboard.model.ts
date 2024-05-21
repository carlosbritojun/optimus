export interface IDashboardModel {
    totalOfProducts: number,
    totalOfCustomers: number,
    productsTop10: [],
    productsWithoutStockOrZero: []
}

export interface IProductTop10 {
    id: string,
    name: string,
    quantityInStock: number
}

export interface IProductWithoutStockOrZero {
    id: string,
    name: string,
    quantityInStock: number
}