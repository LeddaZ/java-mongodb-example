import { readFile } from "fs";
readFile('./ciao.txt', { encoding: 'utf-8' }, (err, content1) => {
    if (err) {
        console.error(err);
    } else {
        console.log(content1);
    }
});
