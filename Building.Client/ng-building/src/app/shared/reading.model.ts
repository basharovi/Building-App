import { Timestamp } from "rxjs";

export class Reading {
    buildingId: number=0;
    dataFieldId: number=0;
    objectId: number=0;
    value: number=0.0;
    timestamp: Date = new Date();
}
