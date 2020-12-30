﻿console.log('Loading');

const aws = require('aws-sdk');
const s3 = new aws.S3({ apiVersion: '2006-03-01' });

exports.handler = function (event, context) {

    if (event != null) {
        console.log('event = ' + JSON.stringify(event));
    }
    else {
        console.log('No event object');

    }
    const bucket = event.Records[0].s3.bucket.name;
    const key = decodeURIComponent(event.Records[0].s3.object.key.replace(/\+/g, ' '));
    const params = {
        Bucket: bucket,
        Key: key,
    };
    try {
        const { ContentType } = await s3.getObject(params).promise();
        console.log('CONTENT TYPE:', ContentType);
        console.log('Key: ', key)

        let Client = require('ssh2-sftp-client');
        let sftp = new Client();
        let path = "/140802/cat/upload/"
        let fullPath = path += key

        sftp.connect({
            host: 'sftp-pl.ct.catnms.com',
            port: '22',
            username: 'cat140802ftp',
            password: 'RoninProfessional1!'
        }).then(() => {
            return sftp.put(key, fullPath);
        }).then(() => {
            return sftp.end();
        }).catch(err => {
            console.error(err.message);
        })

        return ContentType;
    } catch (err) {
        console.log(err);
        const message = `Error getting object ${key} from bucket ${bucket}. Make sure they exist and your bucket is in the same region as this function.`;
        console.log(message);
        throw new Error(message);
    }
    

    context.done(null, 'Hello World');  // SUCCESS with message
};
