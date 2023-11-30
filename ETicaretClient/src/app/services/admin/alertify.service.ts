import { Injectable } from '@angular/core';
declare let alertify: any;
@Injectable({
  providedIn: 'root',
})
export class AlertifyService {
  constructor() {}
  message(message: string, options: Partial<AlertifyOptions>) {
    alertify.set('notifier', 'position', options.position);
    alertify.set('notifier', 'delay', options.delay);
    const msg = alertify[options.messageType](message);
    if (options.dismissOthers) {
      msg.dismissOthers();
    }
  }
  dismissAll() {
    alertify.dismissAll();
  }
}
export class AlertifyOptions {
  messageType: MessageType = MessageType.Message;
  position: Position = Position.BottomLeft;
  delay: number = 3;
  dismissOthers: boolean = false;
}

export enum MessageType {
  Success = 'success',
  Error = 'error',
  Warning = 'warning',
  Info = 'info',
  Message = 'message',
}
export enum Position {
  TopRight = 'top-right',
  TopLeft = 'top-left',
  BottomRight = 'bottom-right',
  BottomLeft = 'bottom-left',
  Center = 'center',
}
