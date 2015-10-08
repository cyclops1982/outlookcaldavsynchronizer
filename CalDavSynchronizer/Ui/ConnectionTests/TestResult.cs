// This file is Part of CalDavSynchronizer (http://outlookcaldavsynchronizer.sourceforge.net/)
// Copyright (c) 2015 Gerhard Zehetbauer 
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
// 
// You should have received a copy of the GNU Affero General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;

namespace CalDavSynchronizer.Ui.ConnectionTests
{
  public class TestResult
  {
    private readonly ResourceType _resourceType;
    private readonly CalendarProperties _calendarProperties;
    private readonly AddressBookProperties _addressBookProperties;

    public TestResult (ResourceType resourceType, CalendarProperties calendarProperties, AddressBookProperties addressBookProperties)
    {
      _resourceType = resourceType;
      _calendarProperties = calendarProperties;
      _addressBookProperties = addressBookProperties;
    }

    public ResourceType ResourceType
    {
      get { return _resourceType; }
    }

    public CalendarProperties CalendarProperties
    {
      get { return _calendarProperties; }
    }

    public AddressBookProperties AddressBookProperties
    {
      get { return _addressBookProperties; }
    }
  }
}