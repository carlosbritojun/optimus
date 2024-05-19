export interface IDashboardModel {
    totalOfProducts: number,
    totalOfCustomers: number,
    productsTop10: [],
    productsWithNegativeOrZero: []
}

export interface IProductTop10 {
    id: string,
    name: string,
    quantityInStock: number
}

export interface IProductWithNegativeOrZero {
    id: string,
    name: string,
    quantityInStock: number
}