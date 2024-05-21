export interface IProductListModel {
    id: number;
    name: string;
    quantityInStock: number;
    costPrice: number;
    salePrice: number;
}

export interface IProductModel {
    name: string,
    quantityInStock: number,
    costPrice: number,
    salePrice: number,
    comments: string 
}