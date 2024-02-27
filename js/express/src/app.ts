import bodyParser from 'body-parser'
import cors from 'cors'
import express from 'express'
import morgan from 'morgan'
import { list, detail } from './api/product/product.controller'
import { add, cartItemList } from './api/cart-item/cart-item.controller'

const app = express()

app.use(cors())
app.use(morgan('tiny'))
app.use(bodyParser.json)

app.get('/products', list)

app.get('/products/:id', detail)

app.get('/cart-items', cartItemList)

app.post('/cart-items', add)

export default app

// const cart: CartItem[] = [
//   {
//     name: 'ssd',
//     netPrice: 95,
//     weight: 100,
//     discount: 5,
//     quantity: 10,
//   },
//   {
//     name: 'motherboard',
//     netPrice: 270,
//     weight: 900,
//     discount: 0,
//     quantity: 1,
//   },
//   {
//     name: 'ram',
//     netPrice: 120,
//     weight: 60,
//     discount: 10,
//     quantity: 2,
//   },
//   {
//     name: 'processor',
//     netPrice: 400,
//     weight: 130,
//     discount: 10,
//     quantity: 1,
//   },
//   {
//     name: 'power supply',
//     netPrice: 130,
//     weight: 1400,
//     discount: 15,
//     quantity: 1,
//   },
//   {
//     name: 'cpu cooler',
//     netPrice: 170,
//     weight: 1000,
//     discount: 23,
//     quantity: 1,
//   },
//   {
//     name: 'gpu',
//     netPrice: 1600,
//     weight: 2500,
//     discount: 0,
//     quantity: 1,
//   },
//   {
//     name: 'case',
//     netPrice: 130,
//     weight: 3500,
//     discount: 30,
//     quantity: 1,
//   },
// ]
