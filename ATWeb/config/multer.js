'use strict';

const multer = require('multer');
const DiskUpload = multer({
    storage: multer.diskStorage({
        destination: function (req, file, callback) {
            callback(null, './uploads');
        },
        filename: function (req, file, callback) {
            callback(null, file.originalname);
        }
    })
});
const MemoryUpload = multer({
    storage: multer.memoryStorage()
});

module.exports = {
    DiskUpload: DiskUpload,
    MemoryUpload: MemoryUpload
};